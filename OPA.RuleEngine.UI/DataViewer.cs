using OPA.RuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.RuleEngine.UI
{
    public static class DataViewer
    {
        public static void DisplayProductDetails(List<ProductDto> productDetails)
        {
            Console.WriteLine("Choose a product type from the list: ");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var product in productDetails)
            {
                Console.WriteLine($"{product.Id} - {product.Description}");
            }

            Console.WriteLine("---------------------------------------------------------------");
        }

        public static void DisplayPaymentTypes(List<PaymentDto> paymentDetails)
        {
            Console.WriteLine("Choose an Payment Method ");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var payment in paymentDetails)
            {
                Console.WriteLine($"{payment.Id} - {payment.Type}");
            }

            Console.WriteLine("---------------------------------------------------------------");
        }

        public static void DisplayMemberShipDetails(List<MembershipDto> memberShipDetails)
        {
            Console.WriteLine("Choose an Membership Type ");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var item in memberShipDetails)
            {
                Console.WriteLine($"{item.Id} - {item.Type}");
            }

            Console.WriteLine("---------------------------------------------------------------");
        }

        internal static void GeneratePackagingSlip(OrderRequestDto orderRequest, Response response)
        {
            //Console.WriteLine("================================================================");
            //Console.WriteLine("================================================================");

            Console.WriteLine("/////////////////////////////////////////////////////////////////");
            Console.WriteLine("================================================================");
            Console.WriteLine("=== PACKAGING SLIP ==");

            Console.WriteLine("================================================================");
            var selectedProduct = orderRequest.ProductDetails;
            Console.WriteLine($"Product Type     =   {selectedProduct.Id} . {selectedProduct.Type}");
            if (!selectedProduct.IsMembershipType)
            {
                Console.WriteLine($"Product Name =  {orderRequest.Name}");
                Console.WriteLine($"Quantity     =  {orderRequest.Quantity}");
            }
            else
            {
                Console.WriteLine($"Membership Type =  {orderRequest.MembershipDetails.Type}");
            }

            if (selectedProduct.IsPaymentRequired)
            {
                Console.WriteLine($"Payment Type   =  {orderRequest.PaymentDetails.Type}");
            }

            if (response.OrderId > 0)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine($"ORDER ID - {response.OrderId}");
            }
            if (!string.IsNullOrEmpty(response.Message))
            {
                Console.WriteLine(response.Message);
            }
            Console.WriteLine("================================================================");
            Console.WriteLine("/////////////////////////////////////////////////////////////////");
        }
    }
}
