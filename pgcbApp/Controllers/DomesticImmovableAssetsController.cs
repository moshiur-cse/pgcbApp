using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class DomesticImmovableAssetsController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        // GET: /DomesticImmovableAssets/
        public ActionResult DomesticImmovableAssets()
        {
            return View();
        }
        [HttpPost]
         public ActionResult DomesticImmovableAssets( List<DomesticImmovableAssets> data)
        {
            long nid = 0;
            foreach (var aData in data)
            {
                aFamilyManager.SaveDomesticImmovableAssets(aData);

                nid = Convert.ToInt64(aData.BasicInformationOfAffectedPersonNid);
            }

           // return View();
            return RedirectToAction("DomesticMovableAssets", "DomesticMovableAssets", new { id = nid });
        }
	}
}


