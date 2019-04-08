using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class ListTicketStandard
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string SessionId { get; set; }
        public string CardNo { get; set; }
    }

    public class result_ListTickettype
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<ListTicketStd_detail> result_tickettype = new List<ListTicketStd_detail>();
    }
    public class ListTicketStd_detail
    {
        public string sstID { get; set; }
        public string Cinema_strID { get; set; }
        public string Session_strID { get; set; }
        public string AreaCat_intSeq { get; set; }
        public string AreaCat_strCode { get; set; }
        public string AreaCat_strSeatAllocationOn { get; set; }
        public string Price_strTicket_Type_Code { get; set; }
        public string Price_strTicket_Type_Description { get; set; }
        public decimal Price_intTicket_Price { get; set; }
        public string Price_strChild_Ticket { get; set; }
        public int Price_intSequence { get; set; }
        public string Price_strPackage { get; set; }
        public string Price_strRedemption { get; set; }
        public string Price_strComp { get; set; }
        public decimal Price_intSurcharge { get; set; }
        public string TType_strMemberCard { get; set; }
        public string TType_strAvailLoyaltyOnly { get; set; }
        public string TicketHasBarcode { get; set; }
        public string TType_strSalesChannels { get; set; }
        public string TType_intBarcodeMaxRepeats { get; set; }
        public string TType_strMaxRepeatsCycle { get; set; }
        public string TType_strUseLoyaltyMemberCard { get; set; }
        public string Member_ClubName { get; set; }
        public decimal PPack_intQuantity { get; set; }
        public string Voucher_Type { get; set; }
        public decimal Seat_intQuantity { get; set; }
        public string MMC_strName { get; set; }
        public string Price_group_code { get; set; }
        public string TType_strHOCode { get; set; }
        public string CardNo { get; set; }
        public string TType_strAvailRecognitionOnly { get; set; }

    }

}