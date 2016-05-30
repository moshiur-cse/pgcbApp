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

        public List<HouseholdYearlyExpenditure> GetAllHouseholdYearlyExpenditure(int qid)
        {
            List<HouseholdYearlyExpenditure> aInfo = new List<HouseholdYearlyExpenditure>();
            Query = "SELECT * FROM HouseholdYearlyExpenditure WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";

            Connection.Open();

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
                int  name = Convert.ToInt32(Reader["FoodExpenditure"]);
                int relation = Convert.ToInt32(Reader["ClothExpenditure"]);
                int age = Convert.ToInt32(Reader["ResidenceRepairingExpenditure"]);
                int gender = Convert.ToInt32(Reader["MedicalExpenditure"]);
                int education = Convert.ToInt32(Reader["EducationalExpenditure"]);
                int professionPrimary = Convert.ToInt32(Reader["CommunicationExpenditure"]);
                int professionSecondary = Convert.ToInt32(Reader["Miscellaneous"]);
                int totalIncomeFromProfession = Convert.ToInt32(Reader["TotalExpenditure"]);

                HouseholdYearlyExpenditure aData = new HouseholdYearlyExpenditure();

                aData.BasicInformationOfAffectedPersonNid = id;
                aData.FoodExpenditure = name;
                aData.ClothExpenditure= relation;
                aData.ResidenceRepairingExpenditure = age;
                aData.MedicalExpenditure = gender;
                aData.EducationalExpenditure = education;
                aData.CommunicationExpenditure = professionPrimary;
                aData.Miscellaneous = professionSecondary;
                aData.TotalExpenditure = totalIncomeFromProfession;
                aInfo.Add(aData);


            }
            Connection.Close();
            return aInfo;
        }
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
        public List<DomesticImmovableAssets> GetAllDomesticImmovableAssets(int qid)
        {
            List<DomesticImmovableAssets> aInfo = new List<DomesticImmovableAssets>();
            Query = "SELECT * FROM DomesticImmovableAssets WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";

            Connection.Open();

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);

                string education = Reader["SocioEconomicData"].ToString();
                int name = Convert.ToInt32(Reader["AmountOwn"]);
                int relation = Convert.ToInt32(Reader["Lease"]);
                int age = Convert.ToInt32(Reader["TentativeAmount"]);
                int gender = Convert.ToInt32(Reader["TotalProducedAmount"]);
              
                DomesticImmovableAssets aData = new DomesticImmovableAssets();

                aData.BasicInformationOfAffectedPersonNid = id;
                aData.SocioEconomicData = education;
                aData.AmountOwn = name;
                aData.Lease = relation;
                aData.TentativeAmount = age;
                aData.TotalProducedAmount = gender;
                
                aInfo.Add(aData);


            }
            Connection.Close();
            return aInfo;
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
        public List<DomesticMovableAssets> GetAllDomesticMovableAssetss(int qid)
        {
            List<DomesticMovableAssets> aInfo = new List<DomesticMovableAssets>();
            Query = "SELECT * FROM DomesticMovableAssets WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";

            Connection.Open();

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);

                string education = Reader["InstitutionTypes"].ToString();
                int name = Convert.ToInt32(Reader["Numbers"]);
                int relation = Convert.ToInt32(Reader["TentativeAmount"]);


                DomesticMovableAssets aData = new DomesticMovableAssets();

                aData.BasicInformationOfAffectedPersonNid = id;
                aData.InstitutionTypes = education;
                aData.Numbers = name;
                aData.TentativeAmount = relation;
                aInfo.Add(aData);


            }
            Connection.Close();
            return aInfo;
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


        public List<HomeResources> GetAllHomeResources(int qid)
        {
            List<HomeResources> aInfo = new List<HomeResources>();
            Query = "SELECT * FROM HomeResources WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";

            Connection.Open();

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);

                string resources = Reader["Resources"].ToString();
                string resourcesName = Reader["ResourcesName"].ToString();
                string others = Reader["Others"].ToString();

                int counts = Convert.ToInt32(Reader["Counts"]);
                long amounts = Convert.ToInt64(Reader["Amounts"]);
                HomeResources aData = new HomeResources();
                aData.BasicInformationOfAffectedPersonNid = id;
                aData.Resources = resources;
                aData.ResourcesName = resourcesName;
                aData.Others = others;

                aData.Count = counts;
                aData.Amount = amounts;
                aInfo.Add(aData);
            }
            Connection.Close();
            return aInfo;
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
        public List<FamilyAffectedLandUsedInformation> GetAllFamilyAffectedLandUsedInformation(int qid)
        {
            List<FamilyAffectedLandUsedInformation> aList = new List<FamilyAffectedLandUsedInformation>();

            Query = @"SELECT * FROM FamilyAffectedLandUsedInformation WHERE BasicInformationOfAffectedPersonNid='" + qid + "'";


            Connection.Open();
            Command.CommandText = Query;
            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
                string jlNo = Reader["JlNo"].ToString();
                string plotNo = Reader["PlotNo"].ToString();
                string totalAcquiedLand = Reader["LandElevation"].ToString();
                string ownershipPattern = Reader["LandUse"].ToString();
                string marketPriceOfAcquiredLand = Reader["PriceOfOthersAssets"].ToString();
             

                FamilyAffectedLandUsedInformation aData = new FamilyAffectedLandUsedInformation();

                aData.BasicInformationOfAffectedPersonNid = id;
                aData.JlNo = jlNo;
                aData.PlotNo = plotNo;
                aData.LandElevation = totalAcquiedLand;
                aData.LandUse = ownershipPattern;
                aData.PriceOfOthersAssets = marketPriceOfAcquiredLand;
                
                aList.Add(aData);
            }
            Connection.Close();
            return aList;
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

