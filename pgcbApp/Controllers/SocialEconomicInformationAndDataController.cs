using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class SocialEconomicInformationAndDataController : Controller
    {
        // GET: SocialEconomicInformationAndData
        SocialEconomicInformationAndDataManager aDataManager=new SocialEconomicInformationAndDataManager();
        public ActionResult SocialEconomicInformationAndData()
        {
            
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult SocialEconomicInformationAndData(List<SocialEconomicInformationAndData> data)
        {
            long nid=0;      
            foreach (var aData in data)
            {
              aDataManager.SaveSocialEconomicInformationAndData(aData);

                 nid = Convert.ToInt64(aData.BasicInformationOfAffectedPersonNid);

            }                      
           // ViewBag.Message = "Successfully Inserted"+message+"Socila-Economic Information";
            return RedirectToAction("FamilyYearlyCost", "FamilyYearlyCost", new { id = nid });
        }


        public ActionResult SocialEconomicInformationAndDataUpdate(int id)
        {
            var data = aDataManager.GetAllSocialEconomicInformationAndData(id);

           
            return View();
        }

    }
}