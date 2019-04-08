using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class UnmarkSeat
    {

        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string SessionID { get; set; }
        public string Type { get; set; }
        public string SelectedSeat { get; set; }
        public string Email { get; set; }
        public string WebSession { get; set; }
    }

    public class result_UnmarkSeat
    {
        public resultmsg result_code = new resultmsg("00", "complete");
    }

}