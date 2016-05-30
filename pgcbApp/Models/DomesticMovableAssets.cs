using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class DomesticMovableAssets
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string InstitutionTypes { get; set; }
        public int Numbers { get; set; }
        public int TentativeAmount { get; set; }
    }
}