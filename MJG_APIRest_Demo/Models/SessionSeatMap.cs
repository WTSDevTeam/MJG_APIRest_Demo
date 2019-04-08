using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class SessionSeatMap
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string SessionId { get; set; }
        public string CardNo { get; set; }
        public string Type { get; set; }
    }



    public class result_SessionSeatMap
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<result_SessionSeatMap_detail> result_data = new List<result_SessionSeatMap_detail>();
        public IList<result_seattype_detail> result_seattype = new List<result_seattype_detail>();
        public IList<result_seatLayoutData_detail> result_seatLayoutData = new List<result_seatLayoutData_detail>();
    }

    public class result_SessionSeatMap_detail
    {
        public string sRow  { get; set; }
        public string sID  { get; set; }
        public string sstID  { get; set; }
        public string sstName  { get; set; }
        public string sStatus  { get; set; }
        public string sIsMark  { get; set; }
        public string sLocation  { get; set; }
        public string sRow_Pair  { get; set; }
        public string sID_Pair  { get; set; }
        public string sLocation_Pair  { get; set; }
        public string sAreaCategoryCode  { get; set; }
    }


    public class result_seattype_detail
    {
        public string sstID { get; set; }
        public string sstCode { get; set; }
        public string sstName { get; set; }
        public decimal sPrice { get; set; }
        public string Price_strTicket_Type_Code { get; set; }

    }

    public class result_seatLayoutData_detail
    {
        public decimal BoundaryRight { get; set; }
        public decimal BoundaryLeft { get; set; }
        public decimal BoundaryTop { get; set; }
        public decimal ScreenStart { get; set; }
        public decimal ScreenWidth { get; set; }
    }
}
