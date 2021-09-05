using OPA.RuleEngine.Model;

namespace OPA.RuleEngine.Business.Manager
{
    public class Payment
    {
        /// <summary>
        /// Process payment for the order
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        public static bool ProcessOrderPayment(OrderRequestDto orderDetails)
        {
            return true;
        }

        /// <summary>
        /// Agent Commission payment
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        public static  bool ProcessCommissionPayment(OrderRequestDto orderDetails)
        {
            return true;
        }
    }
}
