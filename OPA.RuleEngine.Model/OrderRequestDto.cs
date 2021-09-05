using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Model
{
  public  class OrderRequestDto:PaymentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}
