using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormDIDemo.Api
{
    public class AppService : IAppService
    {
        private string Message { get; set; }
        public AppService(string message)
        {
            Message = message;
        }
        public string Hello()
        {
            return $"{Message}";            
        }
    }
}