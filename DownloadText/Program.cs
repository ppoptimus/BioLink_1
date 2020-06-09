using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DownloadText
{
    class Program
    {
        static void Main(string[] args)
        {
            Get();
        }

        public static void Get()
        {
            using (var client = new HttpClient())
            {
                string sourceUri = @"C:\BioLink\EndPointUri.txt";
                string uri = File.ReadLines(sourceUri).First(); //Read Endpoint URL from textFile
                var appSettings = ConfigurationManager.AppSettings["GetText"]; //Get api method from AppSettings

                var response = client.GetAsync(uri + appSettings).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;

                    string responseString = responseContent.ReadAsStringAsync().Result;

                    WriteText(responseString);
                }
            }
        }

        public static void WriteText(string text)
        {
            string sourceFilename = @"C:\BioLink\PathConfig.txt";
            string docPath = File.ReadLines(sourceFilename).First();
            FileInfo fi = new FileInfo(docPath + "\\access-log-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt");

            fi.Delete();
            if (!File.Exists(fi.ToString()))
            {
                using (StreamWriter sw = File.CreateText(fi.ToString()))
                {
                    sw.Write(text);
                }
            }
        }
    }
}
