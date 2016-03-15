using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.StandardOptions
{
    /// <summary>
    /// Aka Level of education
    /// </summary>
    [Table("EducationLevels", Schema="StandardOptions")]
    public class EducationLevel : Base.Base
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
