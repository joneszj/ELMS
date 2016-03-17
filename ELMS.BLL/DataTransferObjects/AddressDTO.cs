using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.DataTransferObjects
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public string AptSuiteOther { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string GoogleMapFormattedAddress { get; set; }
    }
}
