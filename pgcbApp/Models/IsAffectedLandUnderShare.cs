using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class IsAffectedLandUnderShare
    {
        public int  Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string JlNo { get; set; }
        public string PlotNo { get; set; }
        public string TotalAcquiredLand { get; set; }
        public string NameOfShareCropper { get; set; }
    }
}