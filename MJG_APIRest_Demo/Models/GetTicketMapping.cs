using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class GetTicketMapping
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string WebSession { get; set; }
        public string Type { get; set; }
        public string SelectedSeat { get; set; }
        public string CardNoList { get; set; }

    }

    public class result_GetTicketMapping
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<GetTicketMapping_detail> result_ticketmapping = new List<GetTicketMapping_detail>();
    }
    public class GetTicketMapping_detail
    {

        public string sstID { get; set; }
        public string Cinema_strID { get; set; }
        public string Session_strID { get; set; }
        public int AreaCat_intSeq { get; set; }
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
        public int TType_intBarcodeMaxRepeats { get; set; }
        public string TType_strMaxRepeatsCycle { get; set; }
        public string TType_strUseLoyaltyMemberCard { get; set; }
        public string Member_ClubName { get; set; }
        public int PPack_intQuantity { get; set; }
        public string Voucher_Type { get; set; }
        public int Seat_intQuantity { get; set; }
        public string MMC_strName { get; set; }
        public string Price_group_code { get; set; }
        public string TType_strHOCode { get; set; }
        public string CardNo { get; set; }
        public string TType_strAvailRecognitionOnly { get; set; }
        public string VoucherCode { get; set; }
        public string MemberCode { get; set; }
        public string MemberFullName { get; set; }
        public string msSeat { get; set; }
        public string sRow { get; set; }
        public string sID { get; set; }

    }


    public class result_GetTicketMappingPro
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<GetTicketMappingPro_detail> result_ticketmapping = new List<GetTicketMappingPro_detail>();
    }

    public class GetTicketMappingPro_detail
    {

        public string RecogType { get; set; }
        public string RecogID { get; set; }
        public string Message { get; set; }
        public string MessageAltLang { get; set; }
        public string DisplayRecognition { get; set; }
        public string ItemGroup { get; set; }
        public string ItemClass { get; set; }
        public string ItemClassAltLang { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemNameAltLang { get; set; }
        public decimal? QtyToTake { get; set; }
        public decimal? QtyEarned { get; set; }
        public string PriceType { get; set; }
        public decimal? PriceValue { get; set; }
        public string BalanceTypeID { get; set; }
        public decimal? PointsCost { get; set; }
        public string ManuallySelected { get; set; }
        public string EarliestDateTimeAvailable { get; set; }
        public string LatestDateTimeAvailable { get; set; }
        public string ValidDays1 { get; set; }
        public string ValidDays2 { get; set; }
        public string ValidDays3 { get; set; }
        public string ValidDays4 { get; set; }
        public string ValidDays5 { get; set; }
        public string ValidDays6 { get; set; }
        public string ValidDays7 { get; set; }
        public string recognition_clubid { get; set; }
        public string recognition_groupid { get; set; }
        public string recognition_name { get; set; }
        public string recognition_partnerid { get; set; }
        public string recognition_financialCost { get; set; }
        public string recognition_priority { get; set; }
        public string recognition_totalAvailable { get; set; }
        public string recognition_status { get; set; }
        public string recognition_emailPageletid { get; set; }
        public string recognition_SMSPageletid { get; set; }
        public string recognition_POSHeaderPageletid { get; set; }
        public string recognition_limitToATimeRangeid { get; set; }
        public string recognition_limitToAPointOfSaleTypeid { get; set; }
        public string recognition_limitToAComplexid { get; set; }
        public string recognition_howOften { get; set; }
        public string recognition_controlGroupid { get; set; }
        public string recognition_description { get; set; }
        public string recognition_scheduleCalculation { get; set; }
        public string recognition_scheduledCalculationTime { get; set; }
        public string recognition_sequenceNo { get; set; }
        public string recognition_expiredMembers { get; set; }
        public string Priority { get; set; }
        public string sstID { get; set; }
        public string Cinema_strID { get; set; }
        public string Session_strID { get; set; }
        public int AreaCat_intSeq { get; set; }
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
        public int TType_intBarcodeMaxRepeats { get; set; }
        public string TType_strMaxRepeatsCycle { get; set; }
        public string TType_strUseLoyaltyMemberCard { get; set; }
        public string Member_ClubName { get; set; }
        public int PPack_intQuantity { get; set; }
        public string Voucher_Type { get; set; }
        public int Seat_intQuantity { get; set; }
        public string MMC_strName { get; set; }
        public string Price_group_code { get; set; }
        public string TType_strHOCode { get; set; }
        public string TType_strAvailRecognitionOnly { get; set; }
        public string CardNo { get; set; }
        public string MemberCode { get; set; }
        public string MemberFullName { get; set; }
        public string msSeat { get; set; }
        public string sRow { get; set; }
        public string sID { get; set; }
    }

    }
