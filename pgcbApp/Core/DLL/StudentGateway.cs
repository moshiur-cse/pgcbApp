using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using pgcbApp.Models;

namespace pgcbApp.Core.DLL
{
    public class StudentGateway:Gateway
    {
        public int SaveStudent(Student aStudent)
        {
            Query = @"INSERT INTO student (Name,Address) VALUES('" + aStudent.Name + "','" + aStudent.Address + "')";
            Connection.Open();
            Command.CommandText = Query;
            int isRowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return isRowAffected;
        }
    }
}