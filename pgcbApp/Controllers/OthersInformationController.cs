using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class OthersInformationController : Controller
    {
        BasicInformationOfAffectedPersonManager affectedPersonManager=new BasicInformationOfAffectedPersonManager();
        // GET: /OthersInformation/
        public ActionResult OthersInformation()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult OthersInformation( OthersInformation aData)
        {

            int row=affectedPersonManager.SaveOthersInformation(aData);

            ViewBag.Message = "Succesfully Saved "+row+" Informatoin";
            return View();
        }
	}
}