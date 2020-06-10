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
            GetTextFile();
        }

        public static string GetFileName()
        {
            var fileName = "";
            using (var client = new HttpClient())
            {
                string sourceUri = @"C:\BioLink\EndPointUri.txt";
                string uriEndpoint = File.ReadLines(sourceUri).First(); //Read Endpoint URL from textFile
                var uriMethod = ConfigurationManager.AppSettings["GetFileName"]; //Get api method from AppSettings

                try
                {
                    var response = client.GetAsync(uriEndpoint + uriMethod).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;

                        fileName = responseContent.ReadAsStringAsync().Result;
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
               
            }

            return fileName;
        }
        public static void GetTextFile()
        {
            using (var client = new HttpClient())
            {
                var sourceUri = ConfigurationManager.AppSettings["EndPointUri"]; //Get path ที่เก็บ endpoint from AppSettings
                var uriMethod = ConfigurationManager.AppSettings["GetText"]; //Get api method from AppSettings
                var uriEndpoint = File.ReadLines(sourceUri).First(); //Read Endpoint URL from textFile
                var fileName = GetFileName(); //get FileName

                //call web service Mothod GET send with parameter fileName//
                var response = client.GetAsync(uriEndpoint + uriMethod + "?fileName=" + fileName).Result; 

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;

                    string responseString = responseContent.ReadAsStringAsync().Result;

                    WriteText(fileName, responseString);
                }
            }
        }

        public static void WriteText(string fileName, string text)
        {
            string sourceFilename = ConfigurationManager.AppSettings["PathToWriteFile"];
            string docPath = File.ReadLines(sourceFilename).First();
            FileInfo fi = new FileInfo(docPath + @"\" + fileName);

            fi.Delete();
            if (!File.Exists(fi.ToString()))
            {
                using (StreamWriter sw = File.CreateText(fi.ToString()))
                {
                    sw.Write(text);
                }
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                Log("Test1", sw);
                Log("Test2", sw);
            }
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}

/**Hitory 
- เหลือลง log
 **/
