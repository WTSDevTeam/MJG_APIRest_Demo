using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class getloyaltyinfo
    {
        public string CardNo  { get; set; }
        public string TableList  { get; set; }
        public string FieldList  { get; set; }
    }

    public class result_getloyaltyinfo
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<result_getloyaltyinfo_detail> MBRData = new List<result_getloyaltyinfo_detail>();
    }

    public class result_getloyaltyinfo_detail
    {
        public string MemberFullName  { get; set; }
        public decimal QtyAvailable  { get; set; }
        public string MembershipID  { get; set; }
        public string Member_ClubName  { get; set; }
        public string Member_expires  { get; set; }
        public string MemberCode  { get; set; }
        public string MemberLevelID  { get; set; }
        public string MemberLevel  { get; set; }
        public string Member_ClubLevel  { get; set; }
    }
}