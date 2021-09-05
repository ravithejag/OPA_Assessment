using System;
using System.Collections.Generic;
using System.Text;
using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System.Threading.Tasks;
namespace OPA.RuleEngine.Business.Manager
{
    public class PhysicalProduct : IOrder
    {
        private readonly OrderRequestDto orderDetails;
        public PhysicalProduct(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
