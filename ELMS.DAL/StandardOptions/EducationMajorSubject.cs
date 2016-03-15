using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.StandardOptions
{
    /// <summary>
    /// Aka Subjects
    /// </summary>
    [Table("EducationMajorSubjects", Schema="StandardOptions")]
    public class EducationMajorSubject : Base.Base
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public int EducationMajorId { get; set; }
        public virtual EducationMajor EducationMajor { get; set; }
    }
}
