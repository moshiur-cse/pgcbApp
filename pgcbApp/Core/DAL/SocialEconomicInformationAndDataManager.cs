using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Core.DLL;
using pgcbApp.Models;

namespace pgcbApp.Core.DAL
{
    public class SocialEconomicInformationAndDataManager
    {
        SocialEconomicInformationAndDataGateway aSocilalDataGateway=new SocialEconomicInformationAndDataGateway();
        public int SaveSocialEconomicInformationAndData(SocialEconomicInformationAndData aData)
        {
            return aSocilalDataGateway.SaveSocialEconomicInformationAndData(aData);
        }

        public List<SocialEconomicInformationAndData> GetAllSocialEconomicInformationAndData(int qid)
        {
            return aSocilalDataGateway.GetAllSocialEconomicInformationAndData(qid);
        }
    }
}