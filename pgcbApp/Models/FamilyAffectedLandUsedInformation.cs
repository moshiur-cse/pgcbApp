using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class FamilyAffectedLandUsedInformation
    {
        public int  Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string JlNo { get; set; }
        public string PlotNo { get; set; }
        public string LandElevation { get; set; }
        public string LandUse { get; set; }
        public string PriceOfOthersAssets { get; set; }
    }
}