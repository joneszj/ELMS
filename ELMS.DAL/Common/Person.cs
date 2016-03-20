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
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<EducationProfile> EducationProfile { get; set; }
    }
}
