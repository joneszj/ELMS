using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    [Table("SchoolTypes", Schema="Schools")]
    public class SchoolType : Base.Base
    {
        public bool IsPreSchool { get; set; }
        public bool IsElementarySchool { get; set; }
        public bool IsMiddleSchool { get; set; }
        public bool IsHighSchool { get; set; }
        /// <summary>
        /// Represents vocational and technical facilities
        /// </summary>
        public bool IsVocationalSchool { get; set; }
        public bool IsCollege { get; set; }

        public bool IsCampus { get; set; }
        public bool IsOnline { get; set; }

    }
}
