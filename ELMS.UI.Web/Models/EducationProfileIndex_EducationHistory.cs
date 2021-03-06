﻿using ELMS.BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.Models
{
    public class EducationProfileIndex_EducationHistory
    {
        public string InstitutionName { get; set; }
        public int EducationMajorId { get; set; }
        public List<SelectListItemDTO> EducationMajors { get; set; }
        public DateTime? DateDegreeAttained { get; set; }
    }
}