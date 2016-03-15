﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL.StandardOptions
{
    [Table("States", Schema= "StandardOptions")]
    public class State : Base.Base
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
