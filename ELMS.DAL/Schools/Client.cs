using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Schools
{
    [Table("Clients", Schema="Schools")]
    public class Client : Base.Base
    {
        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }
    }
}
