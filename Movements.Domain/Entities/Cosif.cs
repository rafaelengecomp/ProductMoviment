﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movements.Domain.Entities
{
    public class Cosif
    {
        public string CodCosif { get; set; }
        public string CodProduct { get; set; }
        public string CodClassification { get; set; }
        public string Status { get; set; }
        public Product Product { get; set; }
    }
}
