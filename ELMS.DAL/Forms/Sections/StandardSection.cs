using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms.Sections
{
    [Table("StandardSections", Schema = "Sections")]
    public class StandardSection : Base.Base
    {
        public Section Seciton { get; set; }
        public int StandardSectionId { get; set; }
        public virtual StandardSectionType SectionStandardType { get; set; }
    }
}
