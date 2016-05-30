using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class FamilyAffectedLandInformationController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /FamilyAffectedLandInformation/
        public ActionResult FamilyAffectedLandInformation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FamilyAffectedLandInformation(List<FamilyAffectedLandInformation> data)
        {
            long nid = 0;
            foreach (var aData in data)
            {
                aFamilyManager.SaveFamilyAffectedLandInformation(aData);
                nid = aData.BasicInformationOfAffectedPersonNid;
            }

            //return View();
            return RedirectToAction("BasicInformationOfAffectedPersonStepThree", "BasicInformationOfAffectedPersons", new { id = nid });
        }
	}
}