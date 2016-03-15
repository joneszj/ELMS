using ELMS.DAL.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms.Sections
{
    [Table("Sections", Schema = "Sections")]
    public class Section : Base.Base
    {
        public string Container { get; set; }
        public int? FormId { get; set; }
        public virtual Form Form { get; set; }
        public int? SchoolProfileId { get; set; }
        public virtual SchoolProfile SchoolProfile { get; set; }
    }
}
