using System;
using System.Collections.Generic;
using System.Net;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public class RestResult<TModel> 
    {
        public RestResult()
        {
            // 
        }

        public HttpStatusCode StatusCode { get; set; }
        public TModel Data { get; set; }
    }
}
