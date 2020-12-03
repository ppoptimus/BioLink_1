using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            }
        }

        public static string FtpUpload(string sourceFile, string serverPath, string folderPath, string port, string userName, string passWord, string fileNameType, string ftpFileName)
        {
            var result = "";
            var host = "";
            FileInfo fi = new FileInfo(sourceFile);
            if(fileNameType == "1")
            {
                host = "ftp://" + serverPath + ":" + port + "/" + folderPath + "/" + ftpFileName + fi.Extension;
            }
            if(fileNameType == "2")
            {

            }
            //host = "ftp://" + serverPath + ":" + port + "/" + folderPath + "/" + fi.Name;
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
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }


            return result;
        }
    }
}
