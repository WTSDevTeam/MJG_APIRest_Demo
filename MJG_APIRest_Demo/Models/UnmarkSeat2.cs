using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class UnmarkSeat2
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string TransIdTemp { get; set; }
    }
}