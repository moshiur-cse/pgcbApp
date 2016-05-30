using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using pgcbApp.Models;

namespace pgcbApp.Core.DLL
{
    public class SocialEconomicInformationAndDataGateway:Gateway
    {
        public int SaveSocialEconomicInformationAndData(SocialEconomicInformationAndData aData)
        {
            Query = @"INSERT INTO SocialEconomicInformationAndData(BasicInformationOfAffectedPersonNid,NameOfFamilyMember,RelationOfHeadOfTheFamily,Age,Gender,Education,ProfessionPrimary,ProfessionSecondary,TotalIncomeFromProfession) 
           VALUES('" + aData.BasicInformationOfAffectedPersonNid + "','" + aData.NameOfFamilyMember + "','"
                     + aData.RelationOfHeadOfTheFamily + "','" + aData.Age + "','" + aData.Gender + "','" + aData.Education + "','" + aData.ProfessionPrimary + "','" + aData.ProfessionSecondary + "'," +
                     "'" + aData.TotalIncomeFromProfession + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }


        public List<SocialEconomicInformationAndData> GetAllSocialEconomicInformationAndData(int qid)
        {
            List<SocialEconomicInformationAndData> aInfo = new List<SocialEconomicInformationAndData>();
            Query = "SELECT * FROM SocialEconomicInformationAndData WHERE BasicInformationOfAffectedPersonNid='"+qid+"'";

            Connection.Open();

            Command.CommandText = Query;       
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                long id = Convert.ToInt64(Reader["BasicInformationOfAffectedPersonNid"]);
                string name = Reader["NameOfFamilyMember"].ToString();
                string relation  = Reader["RelationOfHeadOfTheFamily"].ToString();
                int  age = Convert.ToInt32(Reader["Age"]);
                string gender = Reader["Gender"].ToString();
                string education = Reader["Education"].ToString();
                string professionPrimary =Reader["ProfessionPrimary"].ToString();
                string professionSecondary = Reader["ProfessionSecondary"].ToString();
                double totalIncomeFromProfession = Convert.ToInt64(Reader["TotalIncomeFromProfession"]);

                SocialEconomicInformationAndData aData=new SocialEconomicInformationAndData();

                aData.BasicInformationOfAffectedPersonNid = id;
                aData.NameOfFamilyMember = name;
                aData.RelationOfHeadOfTheFamily = relation;
                aData.Age = age;
                aData.Gender = gender;
                aData.Education = education;
                aData.ProfessionPrimary = professionPrimary;
                aData.ProfessionSecondary = professionSecondary;
                aData.TotalIncomeFromProfession = totalIncomeFromProfession;
                aInfo.Add(aData);


            }
           return aInfo;
        }
    }
}