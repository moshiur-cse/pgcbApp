using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class DomesticMovableAssetsController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /DomesticMovableAssets/

        public ActionResult DomesticMovableAssets()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DomesticMovableAssets(List<DomesticMovableAssets> data)
        {
            long nid = 0;
            foreach (var aData in data)
            {
                aFamilyManager.SaveDomesticMovableAssets(aData);
                nid = aData.BasicInformationOfAffectedPersonNid;
            }

            //return View();
            return RedirectToAction("HomeResources", "HomeResources", new { id = nid });
        }

	}
}