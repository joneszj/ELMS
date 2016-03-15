using ELMS.DAL.StandardOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Programs
{
    /// <summary>
    /// Represents the relationship between majors, subjects and their respective programs
    /// </summary>
    [Table("ProgramMappings", Schema="Programs")]
    public class ProgramMapping : Base.Base
    {
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }

        public virtual int EducationMajorMappingId { get; set; }
        public virtual EducationMajor EducationMajorMapping { get; set; }
        public virtual int EducationMajorSubjectMappingId { get; set; }
        public virtual EducationMajorSubject EducationMajorSubjectMapping { get; set; }
    }
}
