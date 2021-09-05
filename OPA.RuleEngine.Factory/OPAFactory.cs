using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System;

namespace OPA.RuleEngine.Factory
{
    public abstract class OPAFactory
    {
        public abstract IOrder GetOrderPaymentType(OrderRequestDto orderRequest);
    }
}
