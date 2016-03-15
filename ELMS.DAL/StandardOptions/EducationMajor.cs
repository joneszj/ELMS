using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.StandardOptions
{
    /// <summary>
    /// Aka Area of Study
    /// </summary>
    [Table("EducationMajors", Schema="StandardOptions")]
    public class EducationMajor : Base.Base
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
