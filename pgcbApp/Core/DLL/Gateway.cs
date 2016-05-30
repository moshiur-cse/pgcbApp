using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace pgcbApp.Core.DLL
{
    public class Gateway
    {
        private String connectionString = WebConfigurationManager.ConnectionStrings["pgcb_DBContext"].ConnectionString;
        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        public OleDbDataReader Reader { get; set; }
        public string Query { get; set; }

        public Gateway()
        {
            {
                Connection = new OleDbConnection(connectionString);
                Command = new OleDbCommand();
                Command.Connection = Connection;
            }
        }
    }
}