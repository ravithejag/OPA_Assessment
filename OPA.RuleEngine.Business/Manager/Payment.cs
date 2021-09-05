using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Manager
{
    public class Payment
    {
        public static bool ProcessOrderPayment(OrderRequestDto orderDetails)
        {
            return true;
        }

        public static  bool ProcessCommissionPayment(OrderRequestDto orderDetails)
        {
            return true;
        }
    }
}
