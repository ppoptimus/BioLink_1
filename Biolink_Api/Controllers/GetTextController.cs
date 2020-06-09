using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Biolink_Api.Controllers
{
    public class GetTextController : ApiController
    {
        public virtual IHttpActionResult Get()
        {
            var result = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(System.IO.File.ReadAllBytes(@"c:\TextFileTest\ac_20200607.txt"))
            };

            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return ResponseMessage(result);
        }
    }
}
