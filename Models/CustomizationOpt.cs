﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models
{
    public class CustomizationOpt
    {
        [Key]
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        //public string OptionType { get; set; }=eum
        public double OptionPrice { get; set; }
    }
}
