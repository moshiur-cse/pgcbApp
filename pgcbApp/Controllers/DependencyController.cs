using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class DependencyController : Controller
    {
        // GET: Dependency
        FamilyManager aFamilyManager=new FamilyManager();
        public ActionResult Dependency()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dependency(List<HomeResources> data)
        {
            foreach (var aData in data)
            {
                aFamilyManager.SaveHomeResources(aData);

            }
            return View();
        }
    }
}