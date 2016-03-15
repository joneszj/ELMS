using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Programs
{
    [Table("ProgramTags", Schema="Programs")]
    public class ProgramTag : Base.Base
    {
        public int ProgramId { get; set; }
        public string TagName { get; set; }
    }
}
