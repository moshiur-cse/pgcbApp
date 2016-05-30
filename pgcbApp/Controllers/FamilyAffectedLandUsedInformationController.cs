using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class FamilyAffectedLandUsedInformationController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /FamilyAffectedLandUsedInformation/
        public ActionResult FamilyAffectedLandUsedInformation()
        {
            return View();
        }


       
        [HttpPost]
        public ActionResult FamilyAffectedLandUsedInformation(List<FamilyAffectedLandUsedInformation> data)
        {
            long nid = 0;
            foreach (var aData in data)
            {
                aFamilyManager.SaveFamilyAffectedLandUsedInformation(aData);
                nid = aData.BasicInformationOfAffectedPersonNid;
            }

           // return View();
            return RedirectToAction("AffectedLandPresentCropsAndProductionInformation", "AffectedLandPresentCropsAndProductionInformation", new { id = nid });
        }
	}
}