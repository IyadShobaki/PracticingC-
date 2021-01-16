using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestabilityMosh.UnitTest
{
    [TestClass]
    public class OrderProcessorTest
    {
        // METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order()
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
            
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShippmentPropertyOfTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}

