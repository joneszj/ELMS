using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms.Sections
{
    [Table("StandardSectionTypes", Schema = "Sections")]
    public class StandardSectionType : Base.Base
    {
        public string Name { get; set; }
    }
}
