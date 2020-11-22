using System;
using System.IO;
using System.Net;

namespace BioLinkTaskSchedule.Commands
{
    public class CommandHelper
    {
        //public string UploadFileToFTP(string source)
        //{
        //    var rusult = "test";
        //    //String sourcefilepath = "@absolutepath"; // e.g. "d:/test.docx"
        //    String ftpurl = "ftp://192.168.1.1:21/FTP"; // e.g. ftp://serverip/foldername/foldername
        //    String ftpusername = "PUMPO"; // e.g. username
        //    String ftppassword = ""; // e.g. password
        //    try
        //    {
        //        string filename = Path.GetFileName(source);
        //        string ftpfullpath = ftpurl;
        //        FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
        //        ftp.Credentials = new NetworkCredential(ftpusername, ftppassword);

        //        ftp.KeepAlive = true;
        //        ftp.UseBinary = true;
        //        ftp.Method = WebRequestMethods.Ftp.UploadFile;

        //        FileStream fs = File.OpenRead(source);
        //        byte[] buffer = new byte[fs.Length];
        //        fs.Read(buffer, 0, buffer.Length);
        //        fs.Close();

        //        Stream ftpstream = ftp.GetRequestStream();
        //        ftpstream.Write(buffer, 0, buffer.Length);
        //        ftpstream.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return rusult;
        //}

        public string FtpUpload(string sourceFile, string serverPath, string ftpFolder, string port, string userName, string passWord)
        {
            var result = "";
            FileInfo toUpload = new FileInfo(sourceFile);

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverPath + ":" + "/" + ftpFolder + "/" + toUpload);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(userName, passWord);
                Stream ftpSream = request.GetRequestStream();
                FileStream file = File.OpenRead(sourceFile);

                int len = 1024;
                byte[] buffer = new byte[len];
                int bytesRead = 0;

                do
                {
                    bytesRead = file.Read(buffer, 0, len);
                    ftpSream.Write(buffer, 0, bytesRead);
                }
                while (bytesRead != 0);

                file.Close();
                ftpSream.Close();
                result = "Upload successful";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

    }
}
