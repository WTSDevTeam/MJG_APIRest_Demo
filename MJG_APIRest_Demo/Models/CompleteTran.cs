using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class CompleteTran
    {
        public string ClientName { get; set; }

        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string WebSession { get; set; }
        public string VoucherBarcodeList { get; set; }

    }

    public class result_CompleteTran
    {
        public resultmsg result_code = new resultmsg("00", "complete");
    }

}