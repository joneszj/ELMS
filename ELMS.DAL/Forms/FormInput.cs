using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms
{
    [Table("FormInputs", Schema = "Forms")]
    public class FormInput : Base.Base
    {
        public string Name { get; set; }
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
        public ICollection<FormInputValue> FormValues { get; set; }
    }
}
