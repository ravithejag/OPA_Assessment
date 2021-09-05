using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Manager
{
    public class Book : IOrder
    {
        private readonly OrderRequestDto orderDetails;
        public Book(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
