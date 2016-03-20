using ELMS.BLL.DataTransferObjects;
using ELMS.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELMS.UI.Web.Models
{
    public class ProfileIndex_Address : PartialBase
    {
        public string Street { get; set; }
        public string AptSuiteOther { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        [HiddenInput(DisplayValue = false)]
        public double? Latitude { get; set; }
        [HiddenInput(DisplayValue = false)]
        public double? Longitude { get; set; }
        public string GoogleMapFormattedAddress { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public List<SelectListItemDTO> Countries { get; set; }
        public List<SelectListItemDTO> States { get; set; }
    }
}