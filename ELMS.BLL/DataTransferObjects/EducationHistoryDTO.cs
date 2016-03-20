using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL.DataTransferObjects
{
    public class EducationHistoryDTO
    {
        public string InstitutionName { get; set; }
        public int EducationMajorId { get; set; }
        public DateTime? DateDegreeAttained { get; set; }
    }
}
