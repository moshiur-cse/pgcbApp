using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class HomeResources
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public string Resources { get; set; }
        public string ResourcesName { get; set; }
        public string Others { get; set; }
        public int Count { get; set; }
        public long Amount { get; set; }
    }
}