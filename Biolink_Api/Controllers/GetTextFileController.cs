using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace Biolink_Api.Controllers
{
    public class GetTextFileController : ApiController
    {
        string appSettingPath, pathConfigFileJson;
        public GetTextFileController()
        {
            appSettingPath = ConfigurationManager.AppSettings["TextFilePath"];
            pathConfigFileJson = appSettingPath + @"\appsettings.production.JSON";
        }
        public HttpResponseMessage GetFileName()
        {
            # region //Get export path from appsettings.production.JSON
            string jsonString = File.ReadAllText(pathConfigFileJson);
            var jo = JObject.Parse(jsonString);
            var fileExportPath = jo["ScheduleExport"]["DestinationPath"].ToString();
            #endregion


            var dateFormat = DateTime.Now.AddDays(-1).ToString("yyyyMMdd"); //define date of textFile Export
            string[] fileEntries = Directory.GetFiles(fileExportPath, "*.txt"); //filter file.txt
            string value = Array.Find(fileEntries, element => element.Contains(dateFormat)); //find textFile where FileName Contains last day
            string fileName = Path.GetFileName(value); //get FileName only

            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Content = new StringContent(fileName, System.Text.Encoding.UTF8, "text/plain");

            return resp; //return FileName only
        }
        public virtual IHttpActionResult GetText(string fileName)
        {

            var fileExportPath = @"C:\BioX\export"; //read from appsettings.production.JSON

            var result = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(File.ReadAllBytes(fileExportPath + @"\" + fileName))
            };

            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return ResponseMessage(result);
        }

    }
}
