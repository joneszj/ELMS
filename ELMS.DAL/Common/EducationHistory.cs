﻿using ELMS.DAL.StandardOptions;
using ELMS.DAL.Schools;
using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Common
{
    /// <summary>
    /// Represents the educational history for a person via their education profile
    /// This information is not tied to Schools.School
    /// </summary>
    [Table("EducationHistories", Schema= "Common")]
    public class EducationHistory : Base.Base
    {
        public virtual EducationProfile EducationProfile { get; set; }
        public string InstitutionName { get; set; }
        public int EducationMajorId { get; set; }
        public virtual EducationMajor EducationMajor { get; set; }
        public DateTime? DateDegreeAttained { get; set; }
    }
}
