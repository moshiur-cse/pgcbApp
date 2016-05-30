using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class AffectedLandPresentCropsAndProductionInformationController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /AffectedLandPresentCropsAndProductionInformation/
        public ActionResult AffectedLandPresentCropsAndProductionInformation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AffectedLandPresentCropsAndProductionInformation(List<AffectedLandPresentCropsAndProductionInformation> data)
        {
            long nid = 0;
            foreach (var aData in data)
            {
                aFamilyManager.SaveAffectedLandPresentCropsAndProductionInformation(aData);
                nid = aData.BasicInformationOfAffectedPersonNid;
            }

          //  return View();
            return RedirectToAction("BasicInformationOfAffectedPersonStepFour", "BasicInformationOfAffectedPersons", new { id = nid });
        }
	}
}