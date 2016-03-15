using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.ViewModels
{
    public class ProfileIndex_Address
    {
        public string Street { get; set; }
        public string AptSuiteOther { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
    }
}