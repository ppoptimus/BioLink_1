using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TaskExport.Models;

namespace TaskExport
{
    class Program
    {
        static void Main(string[] args)
        {
            ExportTextFile();            
        }

        private static List<TestTextFile> text_File()
        {
            List<TestTextFile> T_Text_File;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            //client.BaseAddress = new Uri("https://localhost:44306/"); 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/GetData/GetTextFile").Result;
            if (response.IsSuccessStatusCode)
            {
                T_Text_File = response.Content.ReadAsAsync<List<TestTextFile>>().Result;
                return T_Text_File;
            }
            else
            {
                return null;
            }
        }

        private static void ExportTextFile()
        {
            string sourceFilename = @"C:\BioLink\PathConfig.txt";
            string targetFilename = File.ReadLines(sourceFilename).First();
            FileInfo fi = new FileInfo(targetFilename + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt");
            
            fi.Delete();
            if (!File.Exists(fi.ToString()))
            {
                using (StreamWriter sw = File.CreateText(fi.ToString()))
                {
                    foreach(var item in text_File())
                    {
                        sw.WriteLine(string.Format("ID:{0}, TEXT:{1}, Create Date:{2}", item.ID, item.TEXT, item.CREATE_DATE));
                    }
                    
                }
            }
        }
    }
}
