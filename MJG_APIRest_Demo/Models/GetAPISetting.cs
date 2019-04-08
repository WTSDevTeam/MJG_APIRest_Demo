using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class GetAPISetting
    {
        public string AppSetting { get; set; }
    }

    public class result_GetAPISetting
    {
        public string key { get; set; }
        public string value { get; set; }
    }

}