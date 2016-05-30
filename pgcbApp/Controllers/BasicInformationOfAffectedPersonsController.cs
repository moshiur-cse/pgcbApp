using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class BasicInformationOfAffectedPersonsController : Controller
    {
        BasicInformationOfAffectedPersonManager affectedPersonManager=new BasicInformationOfAffectedPersonManager();
        AddressManager addressManager=new AddressManager();
        public ActionResult BasicInformationOfAffectedPerson()
        {
            ViewBag.District = addressManager.GetAllDistrict();
            ViewBag.Message = "";

            return View();
        }
        [HttpPost]
        public ActionResult BasicInformationOfAffectedPerson(BasicInformationOfAffectedPerson affectedPerson)
        {
            
            int row = affectedPersonManager.SaveBasicInformationOfAffectedPerson(affectedPerson);
            int uniqueId = affectedPersonManager.GetuniqueId(affectedPerson.NidCardNumber, affectedPerson.NameOfAffectedPerson, affectedPerson.PhoneNo);

            
                return RedirectToAction("SocialEconomicInformationAndData", "SocialEconomicInformationAndData", new { id = uniqueId });
                                  
        }
        public ActionResult BasicInformationOfAffectedPersonStepTwo()
        {            
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult BasicInformationOfAffectedPersonStepTwo(BasicInformationOfAffectedPerson affectedPerson)
        {
            int message = affectedPersonManager.SaveBasicInformationOfAffectedPersonStep2(affectedPerson);
            ViewBag.Message = "";
            //eturn View();
            return RedirectToAction("FamilyAffectedLandInformation", "FamilyAffectedLandInformation", new { id = affectedPerson.NidCardNumber });
        }

        public ActionResult BasicInformationOfAffectedPersonStepThree()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult BasicInformationOfAffectedPersonStepThree(List<IsAffectedLandUnderShare> data, BasicInformationOfAffectedPerson affectedPerson)
   
        {
            
                foreach (var ta in data)
                {
                    if (ta.JlNo != "" && ta.JlNo!=null)
                    {

                        affectedPersonManager.SaveIsAffectedLandUnderShare(ta);
                    }

                }
            
            int message = affectedPersonManager.SaveBasicInformationOfAffectedPersonStep3(affectedPerson);
            ViewBag.Message = "";
           // return View();
           return RedirectToAction("FamilyAffectedLandUsedInformation", "FamilyAffectedLandUsedInformation", new { id = affectedPerson.NidCardNumber });
        }


        public ActionResult BasicInformationOfAffectedPersonStepFour()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult BasicInformationOfAffectedPersonStepFour(BasicInformationOfAffectedPerson affectedPerson)
        {
            int message = affectedPersonManager.SaveBasicInformationOfAffectedPersonStep4(affectedPerson);
            ViewBag.Message = "Successfully Save All Information";
            return View();
            //return RedirectToAction("FamilyAffectedLandUsedInformation", "FamilyAffectedLandUsedInformation", new { id = affectedPerson.NidCardNumber });
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