using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class AffectedLandPresentCropsAndProductionInformation
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string JlNo { get; set; }
        public string TotalLand { get; set; }
        public string KharifOne { get; set; }
        public string ProductionOne { get; set; }
        public string KharifTwo { get; set; }
        public string ProductionTwo { get; set; }
        public string Robi { get; set; }
        public string ProductionThree { get; set; }
        public string TotalPriceOfTotalProduction { get; set; }
    }
}