using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Core.DLL;
using pgcbApp.Models;

namespace pgcbApp.Core.DAL
{
    public class StudentManager
    {
        StudentGateway aStudentGateway=new StudentGateway();
        public int SaveStudnet(Student aStudent)
        {
            return aStudentGateway.SaveStudent(aStudent);
        }
    }
}