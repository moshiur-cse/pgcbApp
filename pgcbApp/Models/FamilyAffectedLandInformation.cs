using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class FamilyAffectedLandInformation
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }

        public string JlNo { get; set; }
        public string PlotNo { get; set; }
        public string TotalAcquiedLand { get; set; }
        public string OwnershipPattern { get; set; }
        public string MarketPriceOfAcquiredLand { get; set; }
        public string PresentLandUsePattern { get; set; }
    }
}