using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using pgcbApp.Core.DAL;
using pgcbApp.Models;

namespace pgcbApp.Controllers
{
    public class StudentsController : Controller
    {
        StudentManager aStudentManager=new StudentManager();
        // GET: Students
        public ActionResult SaveStudent()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult SaveStudent(List<Student> student)
        {
            foreach (var aStudent in student)
            {
               aStudentManager.SaveStudnet(aStudent);
            }
            //string message = "";
            //int rowAffected = aStudentManager.SaveStudnet(aStudent);
            //if (rowAffected > 0)
            //{
            //    message = "Insert Successfully : " + rowAffected;
            //}
            //else
            //{
            //    message = "Insertion Fails";
            //}
            ViewBag.Message = "Insert Successfully";
            return View();
        }
    }
}