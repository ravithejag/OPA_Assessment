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
        private readonly Random _random = new Random();
        public Book(OrderRequestDto orderRequest)
        {
            orderDetails = orderRequest;
        }
        public async Task<Response> ProcessOrder()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("An Duplicate packing slip for the royalty department");

            bool isPaymentSuccess = Payment.ProcessOrderPayment(orderDetails);

            Console.WriteLine("*********************************************************************");
            if (isPaymentSuccess)
            {
                Console.WriteLine("Payment Has been Processed Successfully to the Agent");
                bool isCOmmissionPaymentSuccess = Payment.ProcessCommissionPayment(orderDetails);
                if (isCOmmissionPaymentSuccess)
                {
                    Console.WriteLine("Commission has been paid to the Agent");
                }
            }
            else
            {
                Console.WriteLine(" Error in processing payment to the Agent");
            }
            Console.WriteLine("*********************************************************************");

            return await Task.FromResult<Response>(new Response { IsSuccess = true, OrderId = _random.Next(99, 99999), TotalCost = orderDetails.Cost * orderDetails.Quantity });
        }
    }
}
