using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Model
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }

        public bool IsPaymentRequired { get; set; }

        public bool IsMembershipType { get; set; }
    }
}
