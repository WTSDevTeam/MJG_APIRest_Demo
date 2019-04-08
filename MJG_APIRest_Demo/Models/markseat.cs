using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class markseat
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string WebSession { get; set; }
        public string Type { get; set; }
        public string SelectedSeat { get; set; }
        public string Promotion { get; set; }
        public string CardNo { get; set; }
        public string VoucherBarcode { get; set; }
        public string Recognition { get; set; }
        public string SessionId { get; set; }

    }
    public class result_markseat
    {
        public resultmsg result_code = new resultmsg("00", "complete");
    }

}