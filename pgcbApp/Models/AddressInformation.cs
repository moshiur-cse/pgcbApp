using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pgcbApp.Models
{
    public class AddressInformation
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public string UpazilaName { get; set; }
        public string UnionName { get; set; }
        public string MauzaName { get; set; }

    }
}