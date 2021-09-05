using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Manager
{
    public class Payment : IPayment
    {
        public Task<bool> ProcessPayment(OrderRequestDto orderDetails)
        {
            throw new NotImplementedException();
        }
    }
}
