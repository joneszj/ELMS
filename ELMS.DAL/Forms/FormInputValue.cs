using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms
{
    [Table("FormInputValues", Schema = "Forms")]
    public class FormInputValue : Base.Base
    {
        public int FormTypeId { get; set; }
        public virtual FormType FormType { get; set; }
        public string Value { get; set; }
    }
}
