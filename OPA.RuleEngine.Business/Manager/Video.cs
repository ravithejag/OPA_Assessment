using System;
using System.Collections.Generic;
using System.Text;
using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System.Threading.Tasks;
namespace OPA.RuleEngine.Business.Manager
{
   public class Video : IOrder
    {
        private readonly OrderRequestDto orderDetails;
        public Video(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public async Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
