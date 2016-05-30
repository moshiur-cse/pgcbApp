using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using pgcbApp.Models;

namespace pgcbApp.Core.DLL
{
    public class BasicInformationOfAffectedPersonGateway:Gateway
    {
        public int SaveBasicInformationOfAffectedPerson(BasicInformationOfAffectedPerson affectedPerson)
        {
            Query = @"INSERT INTO BasicInformationOfAffectedPerson(HouseHoldSlNo,NameOfSs,NameOfAffectedPerson,InsertDate,NidCardNumber,PhoneNo,HusbandOrFathersNameOfAffectedPerson,NameOfHeadOfTheFamily,GenderNameOfHeadOfTheFamily,DistrictName,UpazillaName,UnionName,MauzaName,Ward,VillageName,ProfessionOfAffectedPerson,TypesOfAffectedPeople,FamilyDrinkingWaterDetails,FamilyBathroomDetails,
                      AreYouAwareOfTheProposedProject
                     ,DoYouHaveLandLease,HowManyYears,HowMuchMoney,FamilyStatus,HowDoesTheCostCarryingOut,
                      CreditResponsibility,CreditResponsibilityMoney,CreditResponsibilityReceivedForm,
                     GovernmentBuysCompensation,HowCanYouCompensationMoney,DoYouHaveNeedAnyCommittee,ListOfCommitteeMembers,
                     MainProblemOfYouTerritory,BenefitAfterCompleteProject,
                     DifficultyAfterCompleteProject,AdviseToRemoveDifficulty,DataCollectorFeedback) 
           VALUES('" + affectedPerson.HouseHoldSlNo + "','" + affectedPerson.NameOfSs + "','" + affectedPerson.NameOfAffectedPerson + "','" + affectedPerson.Date + "','"
                     + affectedPerson.NidCardNumber + "','" + affectedPerson.PhoneNo + "','" + affectedPerson.HusbandOrFathersNameOfAffectedPerson + "','" + affectedPerson.NameOfHeadOfTheFamily + "','" + affectedPerson.GenderNameOfHeadOfTheFamily + "'," +
                     "'" + affectedPerson.District + "','" + affectedPerson.Upazilla + "','" + affectedPerson.Union + "','" + affectedPerson.Mauza + "','" + affectedPerson.Ward + "','" + affectedPerson.Village + "','" + affectedPerson.ProfessionOfAffectedPerson + "','" + affectedPerson.TypesOfAffectedPeople + "','" + affectedPerson.FamilyDrinkingWaterDetails + "','" + affectedPerson.FamilyBathroomDetails + "','" + affectedPerson.AreYouAwareOfTheProposedProject +
                              "','" + affectedPerson.DoYouHaveLandLease + "','" + affectedPerson.HowManyYears + "','" + affectedPerson.HowMuchMoney + "','" + affectedPerson.FamilyStatus + "','" + affectedPerson.HowDoesTheCostCarryingOut +
                              "','" + affectedPerson.CreditResponsibility + "','" + affectedPerson.CreditResponsibilityMoney + "','" + affectedPerson.CreditResponsibilityReceivedForm + "','" + affectedPerson.GovernmentBuysCompensation +
                              "','" + affectedPerson.HowCanYouCompensationMoney + "','" + affectedPerson.DoYouHaveNeedAnyCommittee + "','" + affectedPerson.ListOfCommitteeMembers + "','" + affectedPerson.MainProblemOfYouTerritory + "','" +
                                     affectedPerson.BenefitAfterCompleteProject + "','" + affectedPerson.DifficultyAfterCompleteProject + "','" + affectedPerson.AdviseToRemoveDifficulty + "','" + affectedPerson.DataCollectorFeedback + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
        public bool IsNidCardNumberExits(long nidCardNumber)
        {
            bool isRowAffected = false;
            Query = "SELECT * FROM BasicInformationOfAffectedPerson WHERE NidCardNumber=@nidCardNumber";
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("nidCardNumber", SqlDbType.VarChar);
            Command.Parameters["nidCardNumber"].Value = nidCardNumber;
            Command.CommandText = Query;

            Reader = Command.ExecuteReader();

            if (Reader.Read())
            {
                isRowAffected = true;
            }
            Reader.Close();
            Connection.Close();
            return isRowAffected;
        }

        public int GetuniqueId(long nidCardNumber, string name, string phoneNo)
        {
            int id = 0;
            Query = "SELECT ID FROM BasicInformationOfAffectedPerson WHERE NidCardNumber=@nidCardNumber OR NameOfAffectedPerson='" + name + "'  OR PhoneNo='" + phoneNo + "'";
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("nidCardNumber", SqlDbType.VarChar);
            Command.Parameters["nidCardNumber"].Value = nidCardNumber;
            Command.CommandText = Query;

            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
              id = Convert.ToInt32(Reader["ID"]);
            
            }
            Reader.Close();
            Connection.Close();
            return id;
        }
        public int SaveOthersInformation(OthersInformation aData)
        {
            Query = @"INSERT INTO OthersInformation(BasicInformationOfAffectedPersonNid,FamilyDrinkingWaterDetails,FamilyBathroomDetails,
                      AreYouAwareOfTheProposedProject
                     ,DoYouHaveLandLease,HowManyYears,HowMuchMoney,

                     FamilyStatus,HowDoesTheCostCarryingOut,
                      CreditResponsibility,CreditResponsibilityMoney,CreditResponsibilityReceivedForm,

                     GovernmentBuysCompensation,HowCanYouCompensationMoney,DoYouHaveNeedAnyCommittee,ListOfCommitteeMembers,

                     MainProblemOfYouTerritory,BenefitAfterCompleteProject,
                     DifficultyAfterCompleteProject,AdviseToRemoveDifficulty,DataCollectorFeedback) 
                     VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.FamilyDrinkingWaterDetails + "','" + aData.FamilyBathroomDetails + "','" + aData.AreYouAwareOfTheProposedProject +
                              "','" + aData.DoYouHaveLandLease + "','" + aData.HowManyYears + "','" + aData.HowMuchMoney + "','" + aData.FamilyStatus + "','" + aData.HowDoesTheCostCarryingOut +
                              "','" + aData.CreditResponsibility + "','" + aData.CreditResponsibilityMoney + "','" + aData.CreditResponsibilityReceivedForm + "','" + aData.GovernmentBuysCompensation +
                              "','" + aData.HowCanYouCompensationMoney + "','" + aData.DoYouHaveNeedAnyCommittee + "','" + aData.ListOfCommitteeMembers + "','" + aData.MainProblemOfYouTerritory + "','" +
                                     aData.BenefitAfterCompleteProject + "','" + aData.DifficultyAfterCompleteProject + "','" + aData.AdviseToRemoveDifficulty + "','" + aData.DataCollectorFeedback + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }

        public int UpdateAllBasicInformationOfAffectedPerson(BasicInformationOfAffectedPerson aData)
        {
            Query = @"UPDATE BasicInformationOfAffectedPerson SET HouseHoldSlNo='" + aData.HouseHoldSlNo + "',NameOfSs='" + aData.NameOfSs + "',NameOfAffectedPerson='" + aData.NameOfAffectedPerson +
                "',InsertDate='" + aData.Date + "',NidCardNumber='" + aData.NidCardNumber + "',PhoneNo='" + aData.PhoneNo +
                "',HusbandOrFathersNameOfAffectedPerson='" + aData.HusbandOrFathersNameOfAffectedPerson + "',NameOfHeadOfTheFamily='" + aData.NameOfHeadOfTheFamily +
                "',GenderNameOfHeadOfTheFamily='" + aData.GenderNameOfHeadOfTheFamily + "',DistrictName='" + aData.District + "',UpazillaName='" + aData.Upazilla + "',UnionName='" + aData.Union +
                "',MauzaName='" + aData.Mauza + "',Ward='" + aData.Ward + "',VillageName='" + aData.Village + "',ProfessionOfAffectedPerson='" + aData.ProfessionOfAffectedPerson +
                "',TypesOfAffectedPeople='" + aData.TypesOfAffectedPeople + "', FamilyDrinkingWaterDetails='" + aData.FamilyDrinkingWaterDetails + "',FamilyBathroomDetails='" + aData.FamilyBathroomDetails + "',AreYouAwareOfTheProposedProject='" + aData.AreYouAwareOfTheProposedProject + "', DoYouHaveLandLease='" + aData.DoYouHaveLandLease + "',HowManyYears='" + aData.HowManyYears + "',HowMuchMoney='" + aData.HowMuchMoney + "'" +
                    ",FamilyStatus='" + aData.FamilyStatus + "',HowDoesTheCostCarryingOut='"
                + aData.HowDoesTheCostCarryingOut + "',CreditResponsibility='" + aData.CreditResponsibility + "',CreditResponsibilityMoney='" + aData.CreditResponsibilityMoney + "' ,CreditResponsibilityReceivedForm='" + aData.CreditResponsibilityReceivedForm + "',GovernmentBuysCompensation='"
                + aData.GovernmentBuysCompensation + "',HowCanYouCompensationMoney='" + aData.HowCanYouCompensationMoney + "',DoYouHaveNeedAnyCommittee='" + aData.DoYouHaveNeedAnyCommittee + "',ListOfCommitteeMembers='" + aData.ListOfCommitteeMembers + "',MainProblemOfYouTerritory='" + aData.MainProblemOfYouTerritory + "',BenefitAfterCompleteProject='" + aData.BenefitAfterCompleteProject
                + "',DifficultyAfterCompleteProject='" + aData.DifficultyAfterCompleteProject + "',AdviseToRemoveDifficulty='" + aData.AdviseToRemoveDifficulty + "',DataCollectorFeedback='" + aData.DataCollectorFeedback + "' WHERE ID=" + aData.Id;
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;

        }
        public int SaveBasicInformationOfAffectedPersonStep2(BasicInformationOfAffectedPerson aData)
        {
            Query = @"UPDATE BasicInformationOfAffectedPerson SET FamilyDrinkingWaterDetails='" + aData.FamilyDrinkingWaterDetails + "',FamilyBathroomDetails='" + aData.FamilyBathroomDetails + "',AreYouAwareOfTheProposedProject='" + aData.AreYouAwareOfTheProposedProject + "'" +
                    ", DoYouHaveLandLease='" + aData.DoYouHaveLandLease + "',HowManyYears='" + aData.HowManyYears + "',HowMuchMoney='" + aData.HowMuchMoney + "'" +
                    ",FamilyStatus='" + aData.FamilyStatus + "',HowDoesTheCostCarryingOut='"
                + aData.HowDoesTheCostCarryingOut + "',CreditResponsibility='" + aData.CreditResponsibility + "',CreditResponsibilityMoney='" + aData.CreditResponsibilityMoney + "' ,CreditResponsibilityReceivedForm='" + aData.CreditResponsibilityReceivedForm + "',GovernmentBuysCompensation='"
                + aData.GovernmentBuysCompensation + "',HowCanYouCompensationMoney='" + aData.HowCanYouCompensationMoney + "',DoYouHaveNeedAnyCommittee='" + aData.DoYouHaveNeedAnyCommittee + "',ListOfCommitteeMembers='" + aData.ListOfCommitteeMembers + "',MainProblemOfYouTerritory='" + aData.MainProblemOfYouTerritory + "',BenefitAfterCompleteProject='" + aData.BenefitAfterCompleteProject
                + "',DifficultyAfterCompleteProject='" + aData.DifficultyAfterCompleteProject + "',AdviseToRemoveDifficulty='" + aData.AdviseToRemoveDifficulty + "',DataCollectorFeedback='" + aData.DataCollectorFeedback + "' WHERE ID=" + aData.Id;
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;

        }

        public int SaveBasicInformationOfAffectedPersonStep3(BasicInformationOfAffectedPerson aData)
        {
            Query = @"UPDATE BasicInformationOfAffectedPerson SET DoYouHaveLandLease='" + aData.DoYouHaveLandLease + "',HowManyYears='" + aData.HowManyYears + "',HowMuchMoney='" + aData.HowMuchMoney + "' WHERE ID= " + aData.Id;
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;

        }

        public int SaveBasicInformationOfAffectedPersonStep4(BasicInformationOfAffectedPerson aData)
        {
            Query = @"UPDATE BasicInformationOfAffectedPerson SET FamilyStatus='" + aData.FamilyStatus + "',HowDoesTheCostCarryingOut='"
                + aData.HowDoesTheCostCarryingOut + "',CreditResponsibility='" + aData.CreditResponsibility + "',CreditResponsibilityMoney='" + aData.CreditResponsibilityMoney + "' ,CreditResponsibilityReceivedForm='" + aData.CreditResponsibilityReceivedForm + "',GovernmentBuysCompensation='"
                + aData.GovernmentBuysCompensation + "',HowCanYouCompensationMoney='" + aData.HowCanYouCompensationMoney + "',DoYouHaveNeedAnyCommittee='" + aData.DoYouHaveNeedAnyCommittee + "',ListOfCommitteeMembers='" + aData.ListOfCommitteeMembers + "',MainProblemOfYouTerritory='" + aData.MainProblemOfYouTerritory + "',BenefitAfterCompleteProject='" + aData.BenefitAfterCompleteProject
                + "',DifficultyAfterCompleteProject='" + aData.DifficultyAfterCompleteProject + "',AdviseToRemoveDifficulty='" + aData.AdviseToRemoveDifficulty + "',DataCollectorFeedback='" + aData.DataCollectorFeedback + "' WHERE ID= " + aData.Id;
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;

        }
        public int SaveIsAffectedLandUnderShare(IsAffectedLandUnderShare aData)
        {
            Query = @"INSERT INTO IsAffectedLandUnderShare(BasicInformationOfAffectedPersonNid,JlNo,PlotNo,TotalAcquiredLand,NameOfShareCropper) VALUES ('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.JlNo + "','" + aData.PlotNo + "','" + aData.TotalAcquiredLand + "','" + aData.NameOfShareCropper + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;

        }
        public List<IsAffectedLandUnderShare> GetAllIsAffectedLandUnderShare(int qid)
        {
            List<IsAffectedLandUnderShare> alistOfInfo = new List<IsAffectedLandUnderShare>();
            Query = "SELECT * FROM IsAffectedLandUnderShare WHERE BasicInformationOfAffectedPersonNid='" + qid+"'";
            Connection.Open();         
            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);

                string jlNo = Reader["JlNo"].ToString();

                string plotNo = Reader["PlotNo"].ToString();
                string totalAcquiredLand = Reader["TotalAcquiredLand"].ToString();               
                string nameOfShareCropper = Reader["NameOfShareCropper"].ToString();
                IsAffectedLandUnderShare aData=new IsAffectedLandUnderShare();
                aData.BasicInformationOfAffectedPersonNid=id;
                aData.JlNo=jlNo;
                aData.PlotNo=plotNo;
                aData.TotalAcquiredLand=totalAcquiredLand;
                aData.NameOfShareCropper=nameOfShareCropper;
                alistOfInfo.Add(aData);
            }
            return alistOfInfo;

        }
        public List<BasicInformationOfAffectedPerson> GetAllBasicInformationOfAffectedPerson(int nidCardNumber)
        {
            List<BasicInformationOfAffectedPerson> alistOfInfo = new List<BasicInformationOfAffectedPerson>();

            Query = "SELECT * FROM BasicInformationOfAffectedPerson WHERE ID=@nidCardNumber";

            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("nidCardNumber", SqlDbType.VarChar);
            Command.Parameters["nidCardNumber"].Value = nidCardNumber;
            Command.CommandText = Query;
            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                int id = Convert.ToInt32(Reader["ID"]);
               
                int houseHoldSlNo = Convert.ToInt32(Reader["HouseHoldSlNo"]);
                string nameOfSs = Reader["NameOfSs"].ToString();
                string nameOfAffectedPerson = Reader["NameOfAffectedPerson"].ToString();
                DateTime date = Convert.ToDateTime(Reader["InsertDate"]);
                long nidCardNumbers = Convert.ToInt64(Reader["NidCardNumber"]);
                string phoneNo = Reader["PhoneNo"].ToString();

                string husbandOrFathersNameOfAffectedPerson = Reader["HusbandOrFathersNameOfAffectedPerson"].ToString();
                string nameOfHeadOfTheFamily = Reader["NameOfHeadOfTheFamily"].ToString();
                string genderNameOfHeadOfTheFamily = Reader["GenderNameOfHeadOfTheFamily"].ToString();
                string district = Reader["DistrictName"].ToString();
                string upazilla = Reader["UpazillaName"].ToString();
                string union = Reader["UnionName"].ToString();
                string mauza = Reader["MauzaName"].ToString();
                string ward = Reader["Ward"].ToString();
                string village = Reader["VillageName"].ToString();
                string professionOfAffectedPerson = Reader["ProfessionOfAffectedPerson"].ToString();
                string typesOfAffectedPeople = Reader["TypesOfAffectedPeople"].ToString();

                string familyDrinkingWaterDetails = Reader["FamilyDrinkingWaterDetails"].ToString();
                string familyBathroomDetails = Reader["FamilyBathroomDetails"].ToString();
                string areYouAwareOfTheProposedProject = Reader["AreYouAwareOfTheProposedProject"].ToString();
                string doYouHaveLandLease = Reader["DoYouHaveLandLease"].ToString();
                string howManyYears = Reader["HowManyYears"].ToString();
                string howMuchMoney = Reader["HowMuchMoney"].ToString();
                string familyStatus = Reader["FamilyStatus"].ToString();
                string howDoesTheCostCarryingOut = Reader["HowDoesTheCostCarryingOut"].ToString();
                string creditResponsibility = Reader["CreditResponsibility"].ToString();
                string creditResponsibilityMoney = Reader["CreditResponsibilityMoney"].ToString();
                string creditResponsibilityReceivedForm = Reader["CreditResponsibilityReceivedForm"].ToString();
                string governmentBuysCompensation = Reader["GovernmentBuysCompensation"].ToString();
                string howCanYouCompensationMoney = Reader["HowCanYouCompensationMoney"].ToString();
                string doYouHaveNeedAnyCommittee = Reader["DoYouHaveNeedAnyCommittee"].ToString();
                string listOfCommitteeMembers = Reader["ListOfCommitteeMembers"].ToString();
                string mainProblemOfYouTerritory = Reader["MainProblemOfYouTerritory"].ToString();
                string benefitAfterCompleteProject = Reader["BenefitAfterCompleteProject"].ToString();
                string difficultyAfterCompleteProject = Reader["DifficultyAfterCompleteProject"].ToString();
                string adviseToRemoveDifficulty = Reader["AdviseToRemoveDifficulty"].ToString();
                string dataCollectorFeedback = Reader["DataCollectorFeedback"].ToString();

                BasicInformationOfAffectedPerson aData = new BasicInformationOfAffectedPerson(id, houseHoldSlNo,
                    nameOfSs, nameOfAffectedPerson, date, nidCardNumbers, phoneNo, husbandOrFathersNameOfAffectedPerson,
                    nameOfHeadOfTheFamily, genderNameOfHeadOfTheFamily, district, upazilla, union, mauza, ward, village,
                    professionOfAffectedPerson, typesOfAffectedPeople, familyDrinkingWaterDetails, familyBathroomDetails,
                    areYouAwareOfTheProposedProject, doYouHaveLandLease, howManyYears, howMuchMoney, familyStatus,
                    howDoesTheCostCarryingOut, creditResponsibility, creditResponsibilityMoney,
                    creditResponsibilityReceivedForm, governmentBuysCompensation, howCanYouCompensationMoney,
                    doYouHaveNeedAnyCommittee, listOfCommitteeMembers, mainProblemOfYouTerritory,
                    benefitAfterCompleteProject, difficultyAfterCompleteProject, adviseToRemoveDifficulty,
                    dataCollectorFeedback);               
                     alistOfInfo.Add(aData);
            }
            Reader.Close();
            Connection.Close();
            return alistOfInfo;
        }
        

    }
}