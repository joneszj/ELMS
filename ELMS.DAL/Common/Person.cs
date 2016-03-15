using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Standards
{
    /// <summary>
    /// Represents the person for a lead
    /// </summary>
    [Table("People", Schema= "Common")]
    public class Person : Base.Base
    {
        public Guid UserId { get; set; }
        [MinLength(1)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [MinLength(1)]
        public string LastName { get; set; }
        /// <summary>
        /// min 0, leave the BLL to determine max age
        /// </summary>
        [Range(0,int.MaxValue)]
        public int? Age { get; set; }

        public virtual ICollection<Address> Addess { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<EducationProfile> EducationProfile { get; set; }
    }
}
