using ELMS.DAL.Forms.Sections;
using ELMS.DAL.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms
{
    [Table("Forms", Schema = "Forms")]
    public class Form : Base.Base
    {
        public string FormName { get; set; }
        public int FormTypeId { get; set; }
        public virtual FormType FormType { get; set; }
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
