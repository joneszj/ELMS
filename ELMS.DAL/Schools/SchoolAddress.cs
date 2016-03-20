using ELMS.DAL.Schools;
using ELMS.DAL.StandardOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    /// <summary>
    /// Represents a physical address
    /// </summary>
    [Table("SchoolAddresses", Schema= "School")]
    public class SchoolAddress : Base.Base
    {
        public string Street { get; set; }
        public string AptSuiteOther { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string GoogleMapFormattedAddress { get; set; }

        [Key, ForeignKey("School")]
        [Column(Order = 2)]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
        public int? StateId { get; set; }
        public virtual State State { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
