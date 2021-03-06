﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PersonParameter
    {
        [Key]
        public int Id { get; set; }

        public int ParameterId { get; set; }

        public int PersonId { get; set; }

        public int? IntValue { get; set; }

        [MaxLength(1024)]
        public string StringValue { get; set; }

        public DateTime? DateValue { get; set; }

        public float? FloatValue { get; set; }

        public Person Person { get; set; }

        public PrmFactName Parameter { get; set; }
    }
}
