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

                    //Log
                    using (StreamWriter w = File.AppendText(LogPath())){Log(response.RequestMessage.ToString(), "GetFileName", w);}
                    
                    if (response.IsSuccessStatusCode)
                    {
                        using (StreamWriter w = File.AppendText(LogPath())) { Log(response.StatusCode.ToString(), "GetFileName", w); }
                        
                        var responseContent = response.Content;
                        using (StreamWriter w = File.AppendText(LogPath())) { Log(responseContent.ReadAsStringAsync().Result, "GetFileName", w); }
                        
                        fileName = responseContent.ReadAsStringAsync().Result;
                    }
                }
                catch (Exception ex)
                {
                    using (StreamWriter w = File.AppendText(LogPath())) { Log(ex.Message, "GetFileName", w); }
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
                using (StreamWriter w = File.AppendText(LogPath())) { Log(response.RequestMessage.ToString(), "GetTextFile", w); }

                if (response.IsSuccessStatusCode)
                {
                    using (StreamWriter w = File.AppendText(LogPath())) { Log(response.StatusCode.ToString(), "GetTextFile", w); }

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

            if (File.Exists(fi.ToString())) { fi.Delete(); }
            if (!File.Exists(fi.ToString()))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fi.ToString()));
                using (StreamWriter sw = File.CreateText(fi.ToString()))
                {
                    sw.Write(text);
                }
            }
        }

        public static string LogPath()
        {
            var fileName = DateTime.Now.ToString("yyyyMMdd");
            string currentDir = ConfigurationManager.AppSettings["PathToLogs"];
            string path = currentDir + @"\" + fileName + ".txt";
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            return path;
        }

        public static void Log(string logMessage, string logFunction, TextWriter w)
        {
            w.WriteLine($"\r\nAction name :{logFunction} ");
            w.WriteLine($"Create date :{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine($"Message :{logMessage}");
            w.WriteLine("--------------------------------------------------------------");
        }
    }
}

/**Hitory 

 **/
