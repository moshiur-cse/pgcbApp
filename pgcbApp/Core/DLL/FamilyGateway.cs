using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Models;

namespace pgcbApp.Core.DLL
{
    public class FamilyGateway:Gateway
    {
        public int SaveHouseholdYearlyExpenditure(HouseholdYearlyExpenditure aData)
        {
            double total = aData.ClothExpenditure + aData.FoodExpenditure + aData.ResidenceRepairingExpenditure + aData.MedicalExpenditure + aData.EducationalExpenditure + aData.CommunicationExpenditure + aData.Miscellaneous;
            Query = @"INSERT INTO HouseholdYearlyExpenditure(BasicInformationOfAffectedPersonNid,FoodExpenditure,ClothExpenditure,ResidenceRepairingExpenditure,MedicalExpenditure,EducationalExpenditure,CommunicationExpenditure,Miscellaneous,TotalExpenditure) 
           VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.FoodExpenditure + "','"
                     + aData.ClothExpenditure + "','" + aData.ResidenceRepairingExpenditure + "','" + aData.MedicalExpenditure + "','" + aData.EducationalExpenditure + "','" + aData.CommunicationExpenditure + "'," +
                     "'" + aData.Miscellaneous + "','"+total+"')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }

        //public List<HouseholdYearlyExpenditure> GetAllHouseholdYearlyExpenditure(int qid)
        //{
        //    List<HouseholdYearlyExpenditure> aInfo = new List<HouseholdYearlyExpenditure>();
        //    Query = "SELECT * FROM HouseholdYearlyExpenditure WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";

        //    Connection.Open();

        //    Command.CommandText = Query;
        //    Reader = Command.ExecuteReader();
        //    while (Reader.Read())
        //    {
        //        long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
        //        string name = Reader["FoodExpenditure"].ToString();
        //        string relation = Reader["ClothExpenditure"].ToString();
        //        int age = Convert.ToInt32(Reader["ResidenceRepairingExpenditure"]);
        //        string gender = Reader["MedicalExpenditure"].ToString();
        //        string education = Reader["EducationalExpenditure"].ToString();
        //        string professionPrimary = Reader["CommunicationExpenditure"].ToString();
        //        string professionSecondary = Reader["Miscellaneous"].ToString();
        //        double totalIncomeFromProfession = Convert.ToInt64(Reader["TotalExpenditure"]);

        //        SocialEconomicInformationAndData aData = new SocialEconomicInformationAndData();

        //        aData.BasicInformationOfAffectedPersonNid = id;
        //        aData.FoodExpenditure = name;
        //        aData.ClothExpenditure = relation;
        //        aData.ResidenceRepairingExpenditure = age;
        //        aData.MedicalExpenditure = gender;
        //        aData.EducationalExpenditure = education;
        //        aData.CommunicationExpenditure = professionPrimary;
        //        aData.Miscellaneous = professionSecondary;
        //        aData.TotalExpenditure = totalIncomeFromProfession;
        //        aInfo.Add(aData);


        //    }
        //    return aInfo;
        //}
        public int SaveDomesticImmovableAssets(DomesticImmovableAssets aData)
        {
            //double total = aData.ClothExpenditure + aData.FoodExpenditure + aData.ResidenceRepairingExpenditure + aData.MedicalExpenditure + aData.EducationalExpenditure + aData.CommunicationExpenditure + aData.Miscellaneous;
            Query = @"INSERT INTO DomesticImmovableAssets(BasicInformationOfAffectedPersonNid,SocioEconomicData,AmountOwn,Lease,TentativeAmount,TotalProducedAmount) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.SocioEconomicData + "','"
                     + aData.AmountOwn + "','" + aData.Lease + "','" + aData.TentativeAmount + "','" + aData.TotalProducedAmount + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
        public int SaveDomesticMovableAssets(DomesticMovableAssets aData)
        {
            Query = @"INSERT INTO DomesticMovableAssets(BasicInformationOfAffectedPersonNid,InstitutionTypes,Numbers,TentativeAmount) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.InstitutionTypes + "','" + aData.Numbers + "','" + aData.TentativeAmount+"')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
        public int SaveHomeResources(HomeResources aData)
        {
            Query = @"INSERT INTO HomeResources(BasicInformationOfAffectedPersonNid,Resources,ResourcesName,Others,Counts,Amounts) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.Resources + "','" + aData.ResourcesName + "','" + aData.Others + "','" + aData.Count + "','" + aData.Amount + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
         public int SaveFamilyAffectedLandInformation(FamilyAffectedLandInformation aData)
        {
            Query = @"INSERT INTO FamilyAffectedLandInformation(BasicInformationOfAffectedPersonNid,JlNo,PlotNo,TotalAcquiedLand,OwnershipPattern,MarketPriceOfAcquiredLand,PresentLandUsePattern) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.JlNo + "','" + aData.PlotNo + "','" + aData.TotalAcquiedLand + "','" + aData.OwnershipPattern + "','" + aData.MarketPriceOfAcquiredLand + "','" + aData.PresentLandUsePattern + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
         public List<FamilyAffectedLandInformation> GetAllFamilyAffectedLandInformation(int qid)
         {
             List<FamilyAffectedLandInformation> aList=new List<FamilyAffectedLandInformation>();

             Query = @"SELECT * FROM FamilyAffectedLandInformation WHERE BasicInformationOfAffectedPersonNid='"+qid+"'";


             Connection.Open();
             Command.CommandText = Query;
             Reader = Command.ExecuteReader();

             while (Reader.Read())
             {
                  long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
                 string jlNo = Reader["JlNo"].ToString();
                 string plotNo = Reader["PlotNo"].ToString();
                 string totalAcquiedLand = Reader["TotalAcquiedLand"].ToString();
                 string ownershipPattern = Reader["OwnershipPattern"].ToString();
                 string marketPriceOfAcquiredLand = Reader["MarketPriceOfAcquiredLand"].ToString();
                 string presentLandUsePattern = Reader["PresentLandUsePattern"].ToString();

                 FamilyAffectedLandInformation aData=new FamilyAffectedLandInformation();

                 aData.BasicInformationOfAffectedPersonNid = id;
                 aData.JlNo = jlNo;
                 aData.PlotNo = plotNo;
                 aData.TotalAcquiedLand = totalAcquiedLand;
                 aData.OwnershipPattern = ownershipPattern;
                 aData.MarketPriceOfAcquiredLand= marketPriceOfAcquiredLand;
                 aData.PresentLandUsePattern = presentLandUsePattern;
                 aList.Add(aData);
             }
             Connection.Close();
             return aList;
         }
        public int SaveFamilyAffectedLandUsedInformation(FamilyAffectedLandUsedInformation aData)
        {
            Query = @"INSERT INTO FamilyAffectedLandUsedInformation(BasicInformationOfAffectedPersonNid,JlNo,PlotNo,LandElevation,LandUse,PriceOfOthersAssets) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.JlNo + "','" + aData.PlotNo + "','" + aData.LandElevation + "','" + aData.LandUse + "','" + aData.PriceOfOthersAssets + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
         public int SaveAffectedLandPresentCropsAndProductionInformation(AffectedLandPresentCropsAndProductionInformation aData)
        {
            Query = @"INSERT INTO AffectedLandPresentCropsAndProductionInformation(BasicInformationOfAffectedPersonNid,JlNo,TotalLand,KharifOne,ProductionOne,KharifTwo,ProductionTwo,Robi,ProductionThree,TotalPriceOfTotalProduction) 
            VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.JlNo + "','" + aData.TotalLand + "','" + aData.KharifOne + "','" + aData.ProductionOne + "','" + aData.KharifTwo + "','" + aData.ProductionTwo + "','" + aData.Robi + "','" + aData.ProductionThree + "','" + aData.TotalPriceOfTotalProduction + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
         public List<AffectedLandPresentCropsAndProductionInformation> GetAllAffectedLandPresentCropsAndProductionInformation(int qid)
         {
             List<AffectedLandPresentCropsAndProductionInformation> aList = new List<AffectedLandPresentCropsAndProductionInformation>();

             Query = @"SELECT * FROM AffectedLandPresentCropsAndProductionInformation WHERE BasicInformationOfAffectedPersonNid='" + qid+"'";


             Connection.Open();
             Command.CommandText = Query;
             Reader = Command.ExecuteReader();

             while (Reader.Read())
             {
                 long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
                 string jlNo = Reader["JlNo"].ToString();
                 string totalLand = Reader["TotalLand"].ToString();
                 string kharifOne = Reader["KharifOne"].ToString();
                 string productionOne = Reader["ProductionOne"].ToString();
                 string kharifTwo = Reader["KharifTwo"].ToString();
                 string productionTwo = Reader["TotalPriceOfTotalProduction"].ToString();

                 string robi = Reader["Robi"].ToString();
                 string productionThree = Reader["ProductionThree"].ToString();
                 string totalPriceOfTotalProduction = Reader["TotalPriceOfTotalProduction"].ToString();

                 AffectedLandPresentCropsAndProductionInformation aData = new AffectedLandPresentCropsAndProductionInformation();

                 aData.BasicInformationOfAffectedPersonNid = id;
                 aData.JlNo = jlNo;
                 aData.TotalLand = totalLand;
                 aData.KharifOne = kharifOne;
                 aData.ProductionOne = productionOne;
                 aData.KharifTwo = kharifTwo;
                 aData.ProductionTwo = productionTwo;

                 aData.Robi = robi;
                 aData.ProductionThree = productionThree;
                 aData.TotalPriceOfTotalProduction = totalPriceOfTotalProduction;
                 aList.Add(aData);
             }
             Connection.Close();
             return aList;
         }
    }
}

