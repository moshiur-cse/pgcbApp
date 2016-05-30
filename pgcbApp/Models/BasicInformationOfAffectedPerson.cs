using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class BasicInformationOfAffectedPerson
    {
        public BasicInformationOfAffectedPerson()
        {
        }

        public BasicInformationOfAffectedPerson(int id, int houseHoldSlNo, string nameOfSs, string nameOfAffectedPerson, DateTime date, long nidCardNumber, string phoneNo, string husbandOrFathersNameOfAffectedPerson, string nameOfHeadOfTheFamily, string genderNameOfHeadOfTheFamily, string district, string upazilla, string union, string mauza, string ward, string village, string professionOfAffectedPerson, string typesOfAffectedPeople, string familyDrinkingWaterDetails, string familyBathroomDetails, string areYouAwareOfTheProposedProject, string doYouHaveLandLease, string howManyYears, string howMuchMoney, string familyStatus, string howDoesTheCostCarryingOut, string creditResponsibility, string creditResponsibilityMoney, string creditResponsibilityReceivedForm, string governmentBuysCompensation, string howCanYouCompensationMoney, string doYouHaveNeedAnyCommittee, string listOfCommitteeMembers, string mainProblemOfYouTerritory, string benefitAfterCompleteProject, string difficultyAfterCompleteProject, string adviseToRemoveDifficulty, string dataCollectorFeedback)
        {
            Id = id;
            HouseHoldSlNo = houseHoldSlNo;
            NameOfSs = nameOfSs;
            NameOfAffectedPerson = nameOfAffectedPerson;
            Date = date;
            NidCardNumber = nidCardNumber;
            PhoneNo = phoneNo;
            HusbandOrFathersNameOfAffectedPerson = husbandOrFathersNameOfAffectedPerson;
            NameOfHeadOfTheFamily = nameOfHeadOfTheFamily;
            GenderNameOfHeadOfTheFamily = genderNameOfHeadOfTheFamily;
            District = district;
            Upazilla = upazilla;
            Union = union;
            Mauza = mauza;
            Ward = ward;
            Village = village;
            ProfessionOfAffectedPerson = professionOfAffectedPerson;
            TypesOfAffectedPeople = typesOfAffectedPeople;
            FamilyDrinkingWaterDetails = familyDrinkingWaterDetails;
            FamilyBathroomDetails = familyBathroomDetails;
            AreYouAwareOfTheProposedProject = areYouAwareOfTheProposedProject;
            DoYouHaveLandLease = doYouHaveLandLease;
            HowManyYears = howManyYears;
            HowMuchMoney = howMuchMoney;
            FamilyStatus = familyStatus;
            HowDoesTheCostCarryingOut = howDoesTheCostCarryingOut;
            CreditResponsibility = creditResponsibility;
            CreditResponsibilityMoney = creditResponsibilityMoney;
            CreditResponsibilityReceivedForm = creditResponsibilityReceivedForm;
            GovernmentBuysCompensation = governmentBuysCompensation;
            HowCanYouCompensationMoney = howCanYouCompensationMoney;
            DoYouHaveNeedAnyCommittee = doYouHaveNeedAnyCommittee;
            ListOfCommitteeMembers = listOfCommitteeMembers;
            MainProblemOfYouTerritory = mainProblemOfYouTerritory;
            BenefitAfterCompleteProject = benefitAfterCompleteProject;
            DifficultyAfterCompleteProject = difficultyAfterCompleteProject;
            AdviseToRemoveDifficulty = adviseToRemoveDifficulty;
            DataCollectorFeedback = dataCollectorFeedback;
        }

        public int Id { get; set; }
        public int HouseHoldSlNo { get; set; }
        public string NameOfSs { get; set; }   
        public string NameOfAffectedPerson { get; set; }
        public DateTime Date { get; set; }
        public long  NidCardNumber { get; set; }
        public string PhoneNo { get; set; }
        public string HusbandOrFathersNameOfAffectedPerson { get; set; }
        public string NameOfHeadOfTheFamily { get; set; }
        public string GenderNameOfHeadOfTheFamily { get; set; }
        public string District { get; set; }
        public string Upazilla { get; set; }
        public string Union { get; set; }
        public string Mauza { get; set; }

        public string Ward { get; set; }
        public string Village { get; set; }
        public string ProfessionOfAffectedPerson { get; set; }
        public string TypesOfAffectedPeople { get; set; }



        public string FamilyDrinkingWaterDetails { get; set; }
        public string FamilyBathroomDetails { get; set; }
        public string AreYouAwareOfTheProposedProject { get; set; }
        public string DoYouHaveLandLease { get; set; }
        public string HowManyYears { get; set; }
        public string HowMuchMoney { get; set; }
        public string FamilyStatus { get; set; }
        public string HowDoesTheCostCarryingOut { get; set; }
        public string CreditResponsibility { get; set; }
        public string CreditResponsibilityMoney { get; set; }
        public string CreditResponsibilityReceivedForm { get; set; }
        public string GovernmentBuysCompensation { get; set; }
        public string HowCanYouCompensationMoney { get; set; }
        public string DoYouHaveNeedAnyCommittee { get; set; }
        public string ListOfCommitteeMembers { get; set; }
        public string MainProblemOfYouTerritory { get; set; }
        public string BenefitAfterCompleteProject { get; set; }
        public string DifficultyAfterCompleteProject { get; set; }
        public string AdviseToRemoveDifficulty { get; set; }
        public string DataCollectorFeedback { get; set; }

    }
}