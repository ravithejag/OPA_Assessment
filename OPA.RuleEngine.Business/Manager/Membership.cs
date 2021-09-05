using System;
using System.Collections.Generic;
using System.Text;
using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Model;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Business.Manager
{
    public class Membership : IOrder
    {
        private readonly OrderRequestDto orderDetails;
        private readonly Random _random = new Random();
        public Membership(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public async Task<Response> ProcessOrder()
        {
            var memberShipId = orderDetails?.MembershipDetails?.Id;
            var memberShipType = (memberShipId == 1) ? "Activation" : "Upgrade";
            bool isPaymentSuccess = EmailManager.SendMail(new EmailDto());
            Console.WriteLine("*********************************************************************");
            if (isPaymentSuccess)
            {

                Console.WriteLine("An Email has been triggered to the owner Informing about the membership " + memberShipType);
            }
            else
            {
                Console.WriteLine("Error in sending Email to the owner Informing about the membership " + memberShipType);
            }
            Console.WriteLine("*********************************************************************");

            return await Task.FromResult<Response>(new Response { IsSuccess = true, OrderId = _random.Next(99, 99999), TotalCost = orderDetails.Cost });
        }
    }
}
