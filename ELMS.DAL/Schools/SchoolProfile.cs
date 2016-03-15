using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    [Table("SchoolProfiles", Schema="Schools")]
    public class SchoolProfile : Base.Base
    {
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
