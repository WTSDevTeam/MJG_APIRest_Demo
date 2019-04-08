using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class resultmsg
    {
        public string result_code { get; set; }
        public string result_message { get; set; }
        public string TransIdTemp { get; set; }

        public resultmsg(string inCode, string inMessage)
        {
            this.result_code = inCode;
            this.result_message = inMessage;
        }

        public void SetValue(string inCode, string inMessage)
        {
            this.result_code = inCode;
            this.result_message = inMessage;
        }
    }
}
