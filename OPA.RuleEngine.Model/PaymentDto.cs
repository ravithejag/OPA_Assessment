﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Model
{
   public class PaymentDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TypeDetails { get; set; }
    }
}
