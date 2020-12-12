using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TaskFtpUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            GetConfig();
        }

        public static void GetConfig()
        {
            string sourceUri = @"C:\BioLink\FtpConfig.txt";
            string configText = File.ReadLines(sourceUri).First();

            string[] str = configText.Split('|');
            var Source = str[0];
            var Server = str[1];
            var FtpPath = str[2];
            var Port = str[3];
            var UserName = str[4];
            var Password = str[5];
            var fileNameType = str[6];
            var ftpFileName = str[7];

            string result = FtpUpload(Source, Server, FtpPath, Port, UserName, Password, fileNameType, ftpFileName);
            if (!String.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
                //Console.Read();
            }
        }

        public static string FtpUpload(string sourceFile, string serverPath, string folderPath, string port, string userName, string passWord, string fileNameType, string ftpFileName)
        {
            var result = "";
            var host = "";
            var ftpType = (fileNameType == "1") ? "New" : "Replace";
            FileInfo fi = new FileInfo(sourceFile);

            if(fileNameType == "1" || fileNameType == "2")
            {
                host = "ftp://" + serverPath + ":" + port + "/" + folderPath + "/" + ftpFileName + fi.Extension;
            }
            else
            {
                host = "ftp://" + serverPath + ":" + port + "/" + folderPath + "/" + fi.Name;
            }
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential(userName, passWord);
            byte[] fileContents;

            try
            {
                using (StreamReader sourceStream = new StreamReader(sourceFile))
                {
                    fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }

                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    result = response.StatusDescription;
                }
                WriteLog("FtpUpload", sourceFile, serverPath, port, folderPath, userName, "Success", ftpType, ftpFileName + fi.Extension);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                WriteLog("FtpUpload", sourceFile, serverPath, port, folderPath, userName, ex.Message, ftpType, ftpFileName + fi.Extension);
            }


            return result;
        }
    
        public static void WriteLog(string functionName, string sourceFile, string serverPath, string port, string folderPath, string userName, string logMessage, string ftpType, string ftpUploadName)
        {
            string directory = Directory.GetCurrentDirectory() + "\\logs";
            string logFileName = directory + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                if (!File.Exists(logFileName))
                {
                    using (StreamWriter sw = File.CreateText(logFileName))
                    {
                        sw.WriteLine($"Action name : {functionName}");
                        sw.WriteLine($"From source file : {sourceFile}");
                        sw.WriteLine($"Upload to Server : {serverPath}:{port}/{folderPath}");
                        sw.WriteLine($"User upload : {userName}");
                        sw.WriteLine($"Ftp type : {ftpType}");
                        sw.WriteLine($"Ftp file name  : {ftpUploadName}");
                        sw.WriteLine($"Create datetime : {DateTime.Now}");
                        sw.WriteLine($"Message : {logMessage}");
                        sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(logFileName))
                    {
                        sw.WriteLine($"Action name : {functionName}");
                        sw.WriteLine($"From source file : {sourceFile}");
                        sw.WriteLine($"Upload to Server : {serverPath}:{port}/{folderPath}");
                        sw.WriteLine($"User upload : {userName}");
                        sw.WriteLine($"Ftp type : {ftpType}");
                        sw.WriteLine($"Ftp file name  : {ftpUploadName}");
                        sw.WriteLine($"Create datetime : {DateTime.Now}");
                        sw.WriteLine($"Message : {logMessage}");
                        sw.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                    }

                }
            }
            catch (Exception)
            {

            }

        }
    
    }
}
