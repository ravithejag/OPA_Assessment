using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Model
{
  public  class OrderRequestDto
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public ProductDto ProductDetails { get; set; }
        public PaymentDto PaymentDetails { get; set; }
        public MembershipDto MembershipDetails { get; set; }
    }
}
