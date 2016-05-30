using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class HomeResourcesController : Controller
    {
        FamilyManager aFamilyManager=new FamilyManager();
        //
        // GET: /HomeResources/
        public ActionResult HomeResources()
        {
            return View();

        }
        [HttpPost]
        public ActionResult HomeResources(HomeResources aData)
        {
            int rowAffected = aFamilyManager.SaveHomeResources(aData);
            string messages = "Successfully Saved " + rowAffected;
            return RedirectToAction("HomeResources", "HomeResources", new { id = aData.BasicInformationOfAffectedPersonNid, message = messages });
        }

        
    }
}