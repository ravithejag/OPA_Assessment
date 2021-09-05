﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Model
{
  public  class OrderRequestDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }

        public PaymentDto PaymentDetails { get; set; }
        public MembershipDto MembershipDetails { get; set; }
    }
}
