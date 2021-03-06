﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Models
{
    public class FactViewModel
    {
        public int Id { get; set; }
        public int FactId { get; set; }
        public DateTime FactDate { get; set; }
        public string FactName { get; set; }
        public string FactNameRu { get; set; }
        public string MiscValue { get; set; }
        public int? MiscId { get; set; }
        public string StringValue { get; set; }
        public float? FloatValue { get; set; }
        public DateTime? DateValue { get; set; }

        public PrmFactType FactType { get; set; }
        public PrmFactCategory FactCategory { get; set; }
    }

}
