using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class OrderConfirm
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

    public class result_OrderConfirm
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<result_OrderConfirm_detail> result_data = new List<result_OrderConfirm_detail>();
    }

    public class result_OrderConfirm_detail
    {
        public decimal PaymentTotal { get; set; }
    }

}