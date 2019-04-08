using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class BuySeat
    {
        public string ClientName { get; set; }
        public string AuthorizeCode { get; set; }
        public string BranchID { get; set; }
        public string CardType { get; set; }
        public string CardName { get; set; }
        public string WebSession { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTotal { get; set; }
        public string PaymentRef { get; set; }
        public string Phone { get; set; }
        public string CardExpiry { get; set; }
        public string RefNo { get; set; }
        public string RefDetail { get; set; }
        public string PrinterType { get; set; }
    }

    public class result_BuySeat
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<result_BuySeat_detail_Ticket> result_ticket = new List<result_BuySeat_detail_Ticket>();
        public IList<result_BuySeat_detail_printstream> result_printstream = new List<result_BuySeat_detail_printstream>();
    }

    public class result_BuySeat_detail_Ticket
    {
        public string tkmvSName  { get; set; }
        public string tkmvLang  { get; set; }
        public string tkttId  { get; set; }
        public string tkShow_date  { get; set; }
        public string tkShow_time  { get; set; }
        public string tkSeat  { get; set; }
        public string tkTicket_price  { get; set; }
        public string tkMCASH  { get; set; }
        public string tkMsg1   { get; set; }
        public string tkMsg2  { get; set; }
        public string tkTax_id  { get; set; }
        public string tkTax_inv  { get; set; }
        public string tktpId  { get; set; }
    }

    public class result_BuySeat_detail_printstream
    {
        public string PrintStream  { get; set; }
    }
}