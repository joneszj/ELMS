using ELMS.DAL.Programs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    [Table("Brands", Schema="Schools")]
    public class Brand : Base.Base
    {
        public Brand()
        {
            this.Programs = new List<Programs.Program>();
        }

        public string Name { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
    }
}
