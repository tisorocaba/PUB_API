using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PubApi.Data
{
    public class ResponseData
    {
        public string Message { get; set; }
        public Boolean Error { get; set; }
        public object Data { get; set; }
    }
}