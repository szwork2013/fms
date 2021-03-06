﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Models
{

    public class DocumentViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DocumentType Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public IDictionary<string, ParameterViewModel> Parameters { get; set; }
    }
}
