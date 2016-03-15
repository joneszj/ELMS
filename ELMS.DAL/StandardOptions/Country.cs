﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.StandardOptions
{
    /// <summary>
    /// Represents Country information
    /// </summary>
    [Table("Countries", Schema= "StandardOptions")]
    public class Country : Base.Base
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
