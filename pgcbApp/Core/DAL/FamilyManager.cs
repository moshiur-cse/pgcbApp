using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Core.DLL;
using pgcbApp.Models;

namespace pgcbApp.Core.DAL
{
    public class FamilyManager
    {
        FamilyGateway aFamilyGateway=new FamilyGateway();
        public int SaveHouseholdYearlyExpenditure(HouseholdYearlyExpenditure aData)
        {
            return aFamilyGateway.SaveHouseholdYearlyExpenditure(aData);
        }

        public int SaveDomesticImmovableAssets(DomesticImmovableAssets aData)
        {
            return aFamilyGateway.SaveDomesticImmovableAssets(aData);
        }

        public int SaveDomesticMovableAssets(DomesticMovableAssets aData)
        {
            return aFamilyGateway.SaveDomesticMovableAssets(aData);
        }

        public int SaveHomeResources(HomeResources aData)
        {
            return aFamilyGateway.SaveHomeResources(aData);
        }

        public int SaveFamilyAffectedLandInformation(FamilyAffectedLandInformation aData)
        {
            return aFamilyGateway.SaveFamilyAffectedLandInformation(aData);
        }

        public List<FamilyAffectedLandInformation> GetAllFamilyAffectedLandInformation(int qid)
        {
            return aFamilyGateway.GetAllFamilyAffectedLandInformation(qid);
        }

        public int SaveFamilyAffectedLandUsedInformation(FamilyAffectedLandUsedInformation aData)
        {
            return aFamilyGateway.SaveFamilyAffectedLandUsedInformation(aData);
        }

        public int SaveAffectedLandPresentCropsAndProductionInformation(AffectedLandPresentCropsAndProductionInformation aData)
        {
            return aFamilyGateway.SaveAffectedLandPresentCropsAndProductionInformation(aData);
        }

        public List<AffectedLandPresentCropsAndProductionInformation> GetAllAffectedLandPresentCropsAndProductionInformation(int qid)
        {
            return aFamilyGateway.GetAllAffectedLandPresentCropsAndProductionInformation(qid);
        }
    }
}