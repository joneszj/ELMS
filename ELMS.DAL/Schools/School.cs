using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    /// <summary>
    /// Represents a Campus
    /// </summary>
    [Table("Schools", Schema="Schools")]
    public class School : Base.Base
    {
        public string Name { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int SchoolTypeID { get; set; }
        public virtual SchoolType SchoolType { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
