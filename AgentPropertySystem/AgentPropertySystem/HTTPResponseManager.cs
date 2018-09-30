using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AgentPropertySystem
{
    public class HTTPResponseManager
    {
        public ContentResult ReturnHTTPResponse(string ResponseBody, HttpStatusCode StatusCode, string ContentType = "application/json")
        {
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(new { message = ResponseBody }),
                ContentType = ContentType,
                StatusCode = (int)StatusCode
            };
        }
    }
}
