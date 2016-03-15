using ELMS.DAL.StandardOptions;
using ELMS.DAL.Schools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Programs
{
    [Table("Programs", Schema="Programs")]
    public class Program : Base.Base
    {
        public string Name { get; set; }
        public EducationLevel MinEducationLevel { get; set; }
        public EducationLevel MaxEducationLevel { get; set; }
        public ICollection<ProgramMapping> ProgramMapping { get; set; }
        public ICollection<ProgramTag> ProgramTagMapping { get; set; }
        /// <summary>
        /// Brand == Campus
        /// </summary>
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
