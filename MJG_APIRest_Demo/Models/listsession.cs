using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJG_APIRest_Demo.Models
{
    public class listsession
    {
        public string ClientName  { get; set; }
        public string AuthorizeCode  { get; set; }
        public string BranchID  { get; set; }
        public string SessionDate  { get; set; }
        public string OrderBy  { get; set; }
    }

    public class result_listsession
    {
        public resultmsg result_code = new resultmsg("00", "complete");
        public IList<result_listsession_detail> result_data = new List<result_listsession_detail>();
    }

    public class result_listsession_detail
    {
        public string snId  { get; set; }
        public string snttId  { get; set; }
        public string ttName  { get; set; }
        public string snShow_date  { get; set; }
        public string snShow_time  { get; set; }
        public string snmvId  { get; set; }
        public string mvTName  { get; set; }
        public string mvEName  { get; set; }
        public string mvSName  { get; set; }
        public string snmvLang  { get; set; }
        public string snStatus  { get; set; }

        public string snIsReserve  { get; set; }
        public int Seat_intAvailable { get; set; }
        public string Film_strCensor  { get; set; }
        public int Film_intDuration { get; set; }

        //21/1/2015 By Boy
        public string Format_strCode  { get; set; }
        public string Format_strName  { get; set; }
        public string Format_strShortName  { get; set; }

    }
}