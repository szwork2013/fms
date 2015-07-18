﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Models
{
    public class ParameterViewModel
    {
        public int? Id { get; set; }
        public int? PrmId { get; set; }
        public string Name { get; set; }
        public string MiscValue { get; set; }
        public int? MiscId { get; set; }
        public int? DicId { get; set; }
        public string StringValue { get; set; }
        public float? FloatValue { get; set; }
        public DateTime? DateValue { get; set; }
        public ParameterType PrmType { get; set; }
        public ParameterCategory PrmCategory { get; set; }
    }

    public class FactViewModel : ParameterViewModel
    {
        public DateTime? FactDate { get; set; }
    }
}
