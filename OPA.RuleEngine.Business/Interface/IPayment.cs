using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Interface
{
  public  interface IPayment
    {
        Task<bool> ProcessPayment(OrderRequestDto orderDetails);
    }
}
