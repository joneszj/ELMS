using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.ViewModels
{
    public class ProfileIndex_Person
    {
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string FirstName { get; set; }
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string MiddleName { get; set; }
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string LastName { get; set; }
        [Range(0, 120, ErrorMessage = "Must be between 0 and 120")]
        public int? Age { get; set; }
    }
}