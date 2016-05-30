using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class FamilyYearlyCostController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /FamilyYearlyCost/
        public ActionResult FamilyYearlyCost()
        {
            ViewBag.Message = "";

            return View();
        }
        [HttpPost]
        public ActionResult FamilyYearlyCost(HouseholdYearlyExpenditure aData)
        {
            int rowAffected = aFamilyManager.SaveHouseholdYearlyExpenditure(aData);

            ViewBag.Message = "Save Successfully" + rowAffected;
           // return View();
            return RedirectToAction("DomesticImmovableAssets", "DomesticImmovableAssets", new { id = aData.BasicInformationOfAffectedPersonNid });
        }
	}
}