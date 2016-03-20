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
        public string HighSchoolName { get; set; }
        public int? CountyId { get; set; }
        public double? HighSchoolGPA { get; set; }
        public DateTime? HighSchoolGraduationYear { get; set; }
        public bool GED { get; set; }
        public int? SATScore { get; set; }
        public int? ACTScore { get; set; }
        /// <summary>
        /// Not used anymore, but here incase we need it
        /// </summary>
        public int SATScoreOld { get; set; }
        public bool MilitaryExperience { get; set; }

        [Key, ForeignKey("Person")]
        [Column(Order = 2)]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EducationHistory> EducationHistory { get; set; }
        public virtual County County { get; set; }
    }
}
