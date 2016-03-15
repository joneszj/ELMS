using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.DataTransferObjects
{
    public class ContactDTO
    {
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
    }
}
