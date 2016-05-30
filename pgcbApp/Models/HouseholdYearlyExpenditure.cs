using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class HouseholdYearlyExpenditure
    {
        public int Id { get; set; }
        public long BasicInformationOfAffectedPersonNid { get; set; }
        public int FoodExpenditure { get; set; }
        public int ClothExpenditure { get; set; }
        public int ResidenceRepairingExpenditure { get; set; }
        public int MedicalExpenditure { get; set; }
        public int EducationalExpenditure { get; set; }
        public int CommunicationExpenditure { get; set; }
        public int Miscellaneous { get; set; }
        public int TotalExpenditure { get; set; }
    }
}