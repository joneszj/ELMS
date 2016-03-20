using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.DataTransferObjects
{
    public class EducationProfileDTO
    {
        public string HighSchoolName { get; set; }
        public double? HighSchoolGPA { get; set; }
        public DateTime? HighSchoolGraduationYear { get; set; }
        public bool GED { get; set; }
        public int? CountyId { get; set; }
        public int? SATScore { get; set; }
        public int? ACTScore { get; set; }
        public bool MilitaryExperience { get; set; }
    }
}
