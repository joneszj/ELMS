using ELMS.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.Models
{
    public class EducationProfileIndex_EducationProfile
    {
        public int CurrentEducation { get; set; }
        public List<SelectListItemDTO> EducationLevels { get; set; }
        public string HighSchoolName { get; set; }
        /// <summary>
        /// 0.0 - 4.0; 2 digit max precision
        /// </summary>
        [Range(0.0, 4.0)]
        public double? HighSchoolGPA { get; set; }
        public bool GED { get; set; }
        public int? HighSchoolGraduationYear { get; set; }
        public List<SelectListItemDTO> GraduationYears { get; set; }
        public int? CountyId { get; set; }
        [Range(400,1600)]
        public int? SATScore { get; set; }
        [Range(1,36)]
        public int? ACTScore { get; set; }
        public bool MilitaryExperience { get; set; }
        public List<SelectListItemDTO> Counties { get; set; }
        public string partialFormName { get; set; }
    }
}