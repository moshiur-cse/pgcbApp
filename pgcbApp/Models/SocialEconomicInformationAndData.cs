using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class SocialEconomicInformationAndData
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid{ get; set; }
        public string NameOfFamilyMember { get; set; }
        public string RelationOfHeadOfTheFamily { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string ProfessionPrimary { get; set; }
        public string ProfessionSecondary { get; set; }
        public double TotalIncomeFromProfession { get; set; }
       
    }
}