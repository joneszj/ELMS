using ELMS.DAL.StandardOptions;
using ELMS.DAL.Common;
using ELMS.DAL.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Standards
{
    /// <summary>
    /// Represents a leads historical education profile
    /// </summary>
    [Table("EducationProfiles", Schema= "Common")]
    public class EducationProfile : Base.Base
    {
        public EducationProfile()
        {
            this.EducationHistory = new List<EducationHistory>();
        }
        /// <summary>
        /// 0.0 - 4.0; 2 digit max precision
        /// </summary>
        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0.0,4.0)]
        public double HighSchoolGPA { get; set; }
        public DateTime HighSchoolGraduationYear { get; set; }
        //TODO: SAT & ACT Scores

        [Key, ForeignKey("Person")]
        [Column(Order = 2)]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EducationHistory> EducationHistory { get; set; }
    }
}
