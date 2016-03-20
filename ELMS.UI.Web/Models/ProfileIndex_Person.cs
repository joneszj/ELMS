using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.Models
{
    public class ProfileIndex_Person : PartialBase
    {
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string FirstName { get; set; }
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string MiddleName { get; set; }
        [RegularExpression("^[A-Z]'?[- a-zA-Z]+$", ErrorMessage = "Only letters, apostophies, spaces, and hyphens permitted")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateOfBirth { get; set; }
    }
}