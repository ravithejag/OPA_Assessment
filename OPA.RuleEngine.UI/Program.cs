using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.DataAccess.Interface;
using OPA.RuleEngine.Factory;
using OPA.RuleEngine.Model;
using System;

namespace OPA.RuleEngine.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = new OPA.RuleEngine.DataAccess.Manager.DataAccess();
            OrderRequestDto orderRequest = new OrderRequestDto();
            var productDetails = dataAccess.GetProductDetails();
            DataViewer.DisplayProductDetails(productDetails);
            var productId = Convert.ToInt32(Console.ReadLine());

            var selectedProduct = productDetails.Find(x => x.Id == productId);
            orderRequest.ProductDetails = new ProductDto();
            orderRequest.ProductDetails = selectedProduct;

            if (selectedProduct.IsMembershipType)
            {
                var memberShipDetails = dataAccess.GetMemberShipDetails();
                DataViewer.DisplayMemberShipDetails(memberShipDetails);
                orderRequest.MembershipDetails = new MembershipDto();
                orderRequest.MembershipDetails.Id = Convert.ToInt32(Console.ReadLine());
                orderRequest.MembershipDetails.Type = memberShipDetails.Find(x => x.Id == orderRequest.MembershipDetails.Id).Type;
            }
            else
            {
                Console.WriteLine("Please enter the Product Name: ");
                orderRequest.Name = Console.ReadLine();

                Console.WriteLine("Please enter the quantity: ");
                orderRequest.Quantity = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the Product Cost: ");
            orderRequest.Cost = Convert.ToDouble(Console.ReadLine());

            if (selectedProduct.IsPaymentRequired)
            {
                var paymentDetails = dataAccess.GetPaymentTypes();
                DataViewer.DisplayPaymentTypes(paymentDetails);
                orderRequest.PaymentDetails = new PaymentDto();
                orderRequest.PaymentDetails.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Please enter the {paymentDetails.Find(x => x.Id == orderRequest.PaymentDetails.Id).Type} Details ");
                orderRequest.PaymentDetails.TypeDetails = Console.ReadLine();
            }


            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderRequest);

            var response = order.ProcessOrder().Result;

            if (response.IsSuccess)
            {
                DataViewer.GeneratePackagingSlip(orderRequest, response);
            }
            else
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Error in processing the Order.Please try again");
                Console.WriteLine("================================================================");
            }

            Console.ReadLine();
        }
    }
}
