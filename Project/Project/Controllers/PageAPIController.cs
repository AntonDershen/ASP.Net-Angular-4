using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Controllers
{
    public class PageAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(new string[] { "value1", "value2" });
        }
        public HttpResponseMessage Get(int id)
        {
            return ToJson("value");
        }
        public void Post([FromBody]string value)
        {
        }
        public void Put(int id, [FromBody]string value)
        {
        }
        public void Delete(int id)
        {
        }
    }
}
