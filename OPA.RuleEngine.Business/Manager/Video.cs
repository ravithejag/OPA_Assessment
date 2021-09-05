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
        private readonly Random _random = new Random();
        public Video(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public async Task<Response> ProcessOrder()
        {
            Response response = new Response { IsSuccess = true };
            if(orderDetails.Name.Equals("Learning to Ski"))
            {
                response.Message = "An Free First Aid video has been added to the order";
            }
            response.OrderId = _random.Next(0, 99999);
            response.TotalCost = orderDetails.Cost * orderDetails.Quantity;
            return await Task.FromResult<Response>(response);
        }
    }
}
