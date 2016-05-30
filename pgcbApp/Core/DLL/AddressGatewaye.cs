using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;
using pgcbApp.Models;

namespace pgcbApp.Core.DLL
{
    public class AddressGatewaye:Gateway
    {
        public List<AddressInformation> GetAllDistrict()
        {
            List<AddressInformation> aDistrictList = new List<AddressInformation>();
            Query = "SELECT DISTINCT[DistrictName]  FROM AddressInformation ";

            Connection.Open();
            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
               
                string districtName = Reader["DistrictName"].ToString();
                AddressInformation address = new AddressInformation();
                address.DistrictName = districtName;
                aDistrictList.Add(address);
            }
            Reader.Close();
            Connection.Close();
            return aDistrictList;
        }
        public List<AddressInformation> GetAllUpazil(string districtName)
        {
            List<AddressInformation> aUpaziltList = new List<AddressInformation>();
            Query = "SELECT DISTINCT[UpazilaName]  FROM AddressInformation Where DistrictName=@districtName";

            Connection.Open();

            Command.Parameters.Clear();
            Command.Parameters.Add("districtName", SqlDbType.VarChar);
            Command.Parameters["districtName"].Value = districtName;

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string upazilaName = Reader["UpazilaName"].ToString();
                AddressInformation address = new AddressInformation();
                address.UpazilaName = upazilaName;
                aUpaziltList.Add(address);
            }
            Reader.Close();
            Connection.Close();
            return aUpaziltList;
        }
        public List<AddressInformation> GetAllUnion(string upazilaName)
        {
            List<AddressInformation> aUniontList = new List<AddressInformation>();
            Query = "SELECT DISTINCT[UnionName]  FROM AddressInformation Where UpazilaName=@upazilaName";
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.Add("upazilaName", SqlDbType.VarChar);
            Command.Parameters["upazilaName"].Value = upazilaName;

            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string unionName = Reader["UnionName"].ToString();
                AddressInformation address = new AddressInformation();
                address.UnionName = unionName;
                aUniontList.Add(address);
            }
            Reader.Close();
            Connection.Close();
            return aUniontList;
        }
        public List<AddressInformation> GetAllMauza(string unionName)
        {
            List<AddressInformation> aMauzaList = new List<AddressInformation>();
            Query = "SELECT DISTINCT[MauzaName]  FROM AddressInformation Where UnionName='" + unionName + "'";
            Connection.Open();
            Command.CommandText = Query;
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                string mauzaName = Reader["MauzaName"].ToString();
                AddressInformation address = new AddressInformation();
                address.MauzaName = mauzaName;
                aMauzaList.Add(address);
            }
            Reader.Close();
            Connection.Close();
            return aMauzaList;
        }
    }
}