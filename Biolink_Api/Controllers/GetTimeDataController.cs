using Biolink_Api.Services;
using Newtonsoft.Json;
using System;
using System.Web.Http;

namespace Biolink_Api.Controllers
{
    public class GetTimeDataController : ApiController
    {
        ConnectionConfig ConnectionConfig = new ConnectionConfig();
        private GetTimeDataController()
        {
            ConnectionConfig.ConnectMySql();
        }

        public IHttpActionResult GetExport()
        {
            string str = ConnectionConfig.ExportText();
            try
            {
                dynamic jsons = JsonConvert.DeserializeObject(str);
                return Ok(jsons);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message + " Because " + str );
            }
            
        }

    }
}
