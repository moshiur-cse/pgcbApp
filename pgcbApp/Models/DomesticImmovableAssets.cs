using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class DomesticImmovableAssets
    {
        public int  Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string SocioEconomicData { get; set; }
        public int AmountOwn { get; set; }
        public int Lease { get; set; }
        public int TentativeAmount { get; set; }
        public int TotalProducedAmount { get; set; }
       

    }
}