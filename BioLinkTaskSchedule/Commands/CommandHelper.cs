using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BioLinkTaskSchedule.Commands
{
    public class CommandHelper
    {
        public string FtpUpload(string sourceFile, string serverPath, string folderPath, string port, string userName, string passWord)
        {
            var result = "";

            FileInfo fi = new FileInfo(sourceFile);
            var host = "ftp://" + serverPath + ":" + port + "/" + folderPath + "/" + fi.Name;
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

        public bool CheckFTPConnection(string URL, string username, string password)
        {
            Uri siteUri = new Uri(URL);
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(siteUri);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;
            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException e)
            {
                //if (e.Status == WebExceptionStatus.ProtocolError)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                return false;
            }
        }

    }
}
