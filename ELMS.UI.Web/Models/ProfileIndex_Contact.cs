using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELMS.UI.Web.Models
{
    public class ProfileIndex_Contact : PartialBase
    {
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
    }
}