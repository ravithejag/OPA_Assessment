using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPA.RuleEngine.Business.Interface;
using OPA.RuleEngine.Factory;
using OPA.RuleEngine.Model;
using System.Threading.Tasks;

namespace OPA.RuleEngine.Tests
{
    [TestClass]
    public class OrderTest
    {
        public OrderRequestDto GetOrderDetails(int productId, int cost, int quantity, bool isMembershipType = false, bool isPaymentRequired = false)
        {
            return new OrderRequestDto
            {
                Name = "Test Product",
                Quantity = quantity,
                Cost = cost,
                ProductDetails = new ProductDto
                {
                    Id = productId,
                    IsMembershipType = isMembershipType,
                    IsPaymentRequired = isPaymentRequired
                },
                PaymentDetails = isPaymentRequired ? new PaymentDto { Id = 1, Type = "Credit Card" } : null,
                MembershipDetails = isMembershipType ? new MembershipDto { Id = 1, Type = "New" } : null
            };
        }

        [TestMethod]
        public async Task Physical_Product_Order_Success()
        {
            var orderDetails = GetOrderDetails(1, 50, 2, isPaymentRequired: true);
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreEqual(orderDetails.Quantity * orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task Book_Order_Success()
        {
            var orderDetails = GetOrderDetails(2, 50, 2, isPaymentRequired: true);
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreEqual(orderDetails.Quantity * orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task MemberShip_Activation_Order_Success()
        {
            var orderDetails = GetOrderDetails(3, 50, 2, isPaymentRequired: true);
            orderDetails.MembershipDetails = new MembershipDto { Id = 1, Type = "New Activation" };
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreEqual(orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task MemberShip_Upgrade_Order_Success()
        {
            var orderDetails = GetOrderDetails(3, 50, 2, isPaymentRequired: true);
            orderDetails.MembershipDetails = new MembershipDto { Id = 2, Type = "Upgrade" };
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreEqual(orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task MemberShip_Activation_Order_Failure()
        {
            var orderDetails = GetOrderDetails(2, 50, 2, isPaymentRequired: true);
            orderDetails.MembershipDetails = new MembershipDto { Id = 1, Type = "New Activation" };
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreNotEqual(orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task Video_Order_Success()
        {
            var orderDetails = GetOrderDetails(4, 50, 2, isPaymentRequired: true);
            orderDetails.Name = "test video";
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.AreEqual(orderDetails.Quantity * orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task Video_Order_Success_2()
        {
            var orderDetails = GetOrderDetails(4, 50, 2, isPaymentRequired: true);
            orderDetails.Name = "Learning to Ski";
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.IsTrue(response.Message == "An Free First Aid video has been added to the order");
            Assert.AreEqual(orderDetails.Quantity * orderDetails.Cost, response.TotalCost);
        }

        [TestMethod]
        public async Task Video_Order_Failure()
        {
            var orderDetails = GetOrderDetails(4, 50, 2, isPaymentRequired: true);
            orderDetails.Name = "Learning to Ski2";
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(orderDetails);

            var response = await order.ProcessOrder().ConfigureAwait(false);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.OrderId > 0);
            Assert.IsFalse(response.Message == "An Free First Aid video has been added to the order");
            Assert.AreEqual(orderDetails.Quantity * orderDetails.Cost, response.TotalCost);
        }
    }
}
