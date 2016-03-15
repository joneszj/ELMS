using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.Forms
{
    /// <summary>
    /// Form types primarially represent the presentation layer the form will display on (ex. html)
    /// </summary>
    [Table("FormTypes", Schema = "Forms")]
    public class FormType : Base.Base
    {
        public string Name { get; set; }
    }
}
