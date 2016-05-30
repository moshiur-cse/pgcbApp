using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
        public class ShowDetailsInformationController : Controller
    {
        BasicInformationOfAffectedPersonManager affectedPersonManager=new BasicInformationOfAffectedPersonManager();
        AddressManager addressManager=new AddressManager();
        SocialEconomicInformationAndDataManager aSocialEconomicInformationAndDataManager=new SocialEconomicInformationAndDataManager();
        FamilyManager aFamilyManager=new FamilyManager();
            SocialEconomicInformationAndDataManager andDataManager=new SocialEconomicInformationAndDataManager();
        // GET: /ShowDetailsInformation/
        public ActionResult ShowDetailsInformation()
        {
            ViewBag.District = addressManager.GetAllDistrict();
            string message = "";
            ViewBag.Message = message;
            return View();
        }
        [HttpPost]
        public ActionResult ShowDetailsInformation(int id)
        {
            ViewBag.District = addressManager.GetAllDistrict();
            var info = affectedPersonManager.GetAllBasicInformationOfAffectedPerson(id);
            var allIsAffectedLandUnderShare = affectedPersonManager.GetAllIsAffectedLandUnderShare(id);
            var aFamilyAffectedLandInformation = aFamilyManager.GetAllFamilyAffectedLandInformation(id);
            var aAffectedLandPresentCropsAndProductionInformation = aFamilyManager.GetAllAffectedLandPresentCropsAndProductionInformation(id);
            var aSocialEconomicInformationAndData = andDataManager.GetAllSocialEconomicInformationAndData(id);
            var aHouseholdYearlyExpenditure = aFamilyManager.GetAllHouseholdYearlyExpenditure(id);
            var aDomesticImmovableAssets = aFamilyManager.GetAllDomesticImmovableAssets(id);

            var aDomesticMovableAsset = aFamilyManager.GetAllDomesticMovableAssetss(id);
            var aHomeResources = aFamilyManager.GetAllHomeResources(id);
            var aFamilyAffectedLandUsedInformation = aFamilyManager.GetAllFamilyAffectedLandUsedInformation(id);
            
            if (info.Count==0)
            {
                string message = "No Information Found";
                ViewBag.Message = message;
            }
            ViewBag.DetailsInfo = info;
            ViewBag.AllIsAffectedLandUnderShare = allIsAffectedLandUnderShare;
            ViewBag.FamilyAffectedLandInformation = aFamilyAffectedLandInformation;
            ViewBag.AffectedLandPresentCropsAndProductionInformation = aAffectedLandPresentCropsAndProductionInformation;
            ViewBag.SocialEconomicInformationAndData = aSocialEconomicInformationAndData;
            ViewBag.HouseholdYearlyExpenditure = aHouseholdYearlyExpenditure;
            ViewBag.DomesticImmovableAssets = aDomesticImmovableAssets;
            ViewBag.DomesticMovableAssets = aDomesticMovableAsset;
            ViewBag.HomeResources = aHomeResources;
            ViewBag.FamilyAffectedLandUsedInformation = aFamilyAffectedLandUsedInformation;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateDetailsInformation([Bind]BasicInformationOfAffectedPerson affectedPerson, [Bind(Include ="BasicInformationOfAffectedPersonNid,JlNo,PlotNo,TotalAcquiedLand,OwnershipPattern,MarketPriceOfAcquiredLand,PresentLandUsePattern")]List<FamilyAffectedLandInformation> data, List<IsAffectedLandUnderShare> data2, List<FamilyAffectedLandUsedInformation> data3)
        {
            //foreach (var aData in data)
            //{
            //    long a=aData.BasicInformationOfAffectedPersonNid;

            //}
            string message = "";
            int count = affectedPersonManager.UpdateAllBasicInformationOfAffectedPerson(affectedPerson);
            if (count>0)
            {

                message = "Successfully Update Information";
            }
            return RedirectToAction("ShowDetailsInformation", "ShowDetailsInformation", new { id = message });
            
        }
        public JsonResult GetUpazilaByDistrictName(string districtName)
        {
            var allUpasilaName = addressManager.GetAllUpazil(districtName);
            return Json(allUpasilaName, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetUnionByUpazilaNmae(string upazilaName)
        {
            var allUnionName = addressManager.GetAllUnion(upazilaName);
            return Json(allUnionName, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMauzaByUnionNmae(string unionName)
        {
            var allMauzaName = addressManager.GetAllMauza(unionName);
            return Json(allMauzaName, JsonRequestBehavior.AllowGet);
        }       
	}
}