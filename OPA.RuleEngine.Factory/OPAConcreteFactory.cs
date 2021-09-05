using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Business.Manager;
using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.Factory
{
    public class OPAConcreteFactory : OPAFactory
    {
        /// <summary>
        /// Get Order Object based on the order id
        /// </summary>
        /// <param name="orderRequest"></param>
        /// <returns></returns>
        public override IOrder GetOrderPaymentType(OrderRequestDto orderRequest)
        {
            IOrder order;
            switch (orderRequest.Id)
            {
                case 1:
                    order = new PhysicalProduct(orderRequest);
                    break;
                case 2:
                    order = new Book(orderRequest);
                    break;
                case 3:
                    order = new Membership(orderRequest);
                    break;
                case 5:
                    order = new Video(orderRequest);
                    break;
                default:
                    throw new ApplicationException("Error in processing the payment, Please try again");
                    ///break;
            }
            return order;
        }
    }
}
