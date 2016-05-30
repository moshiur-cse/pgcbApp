using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Core.DLL;
using pgcbApp.Models;

namespace pgcbApp.Core.DAL
{
    public class BasicInformationOfAffectedPersonManager
    {
        BasicInformationOfAffectedPersonGateway affectedPersonGateway=new BasicInformationOfAffectedPersonGateway();
        public int SaveBasicInformationOfAffectedPerson(BasicInformationOfAffectedPerson affectedPerson)
        {
            //string message = "";
            //bool isNidCardNumberExits = affectedPersonGateway.IsNidCardNumberExits(affectedPerson.NidCardNumber);
            //if (isNidCardNumberExits)
            //{
            //    message = "Nid Card Number Already Exits";
            //}
            //else
            //{
            //    affectedPersonGateway.SaveBasicInformationOfAffectedPerson(affectedPerson);
            //}



            return affectedPersonGateway.SaveBasicInformationOfAffectedPerson(affectedPerson);
        }

        public int UpdateAllBasicInformationOfAffectedPerson(BasicInformationOfAffectedPerson aData)
        {
            return affectedPersonGateway.UpdateAllBasicInformationOfAffectedPerson(aData);
        }

        public int GetuniqueId(long nidCardNumber, string name, string phoneNo)
        {
            return affectedPersonGateway.GetuniqueId(nidCardNumber, name, phoneNo);
        }

        public int SaveOthersInformation(OthersInformation aData)
        {
            return affectedPersonGateway.SaveOthersInformation(aData);
        }
         public int SaveBasicInformationOfAffectedPersonStep2(BasicInformationOfAffectedPerson aData)
         {
             return affectedPersonGateway.SaveBasicInformationOfAffectedPersonStep2(aData);
         }

        public int SaveBasicInformationOfAffectedPersonStep3(BasicInformationOfAffectedPerson aData)
        {
            return affectedPersonGateway.SaveBasicInformationOfAffectedPersonStep3(aData);
        }

        public int SaveBasicInformationOfAffectedPersonStep4(BasicInformationOfAffectedPerson aData)
        {
            return affectedPersonGateway.SaveBasicInformationOfAffectedPersonStep4(aData);
        }

        public int SaveIsAffectedLandUnderShare(IsAffectedLandUnderShare aData)
        {
            return affectedPersonGateway.SaveIsAffectedLandUnderShare(aData);
        }
        public List<IsAffectedLandUnderShare> GetAllIsAffectedLandUnderShare(int qid)
        {
            return affectedPersonGateway.GetAllIsAffectedLandUnderShare(qid);
        }

        public List<BasicInformationOfAffectedPerson> GetAllBasicInformationOfAffectedPerson(int nid)
        {
            return affectedPersonGateway.GetAllBasicInformationOfAffectedPerson(nid);
        }
    }
}