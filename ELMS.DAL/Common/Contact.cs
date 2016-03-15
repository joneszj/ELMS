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
    /// Represents contact information for a person
    /// </summary>
    [Table("Contacts", Schema= "Common")]
    public class Contact : Base.Base
    {
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }

        [Key, ForeignKey("Person")]
        [Column(Order = 2)]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
