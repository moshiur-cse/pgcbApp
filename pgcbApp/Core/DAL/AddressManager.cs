using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pgcbApp.Core.DLL;
using pgcbApp.Models;

namespace pgcbApp.Core.DAL
{
    public class AddressManager
    {
        AddressGatewaye addressGatewaye=new AddressGatewaye();

        public List<AddressInformation> GetAllDistrict()
        {
            return addressGatewaye.GetAllDistrict();
        }

        public List<AddressInformation> GetAllUpazil(string districtName)
        {
            return addressGatewaye.GetAllUpazil(districtName);
        }

        public List<AddressInformation> GetAllUnion(string upazilaName)
        {
            return addressGatewaye.GetAllUnion(upazilaName);
        }

        public List<AddressInformation> GetAllMauza(string unionName)
        {
            return addressGatewaye.GetAllMauza(unionName);
        }
    }
}