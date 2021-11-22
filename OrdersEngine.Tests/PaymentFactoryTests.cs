using OrdersEngine.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace OrdersEngine.Tests
{
    public class PaymentFactoryTests
    {
        PaymentFactory _factory;

        public PaymentFactoryTests()
        {
            _factory = new PaymentFactory();
        }

        [Fact]
        public void PaymentForPhysicalProductTest()
        {
            var factory = new PhysicalProductFactory();
            var processedPayment = factory.CreateProduct(100);
            Assert.IsType<PackingSlip>(processedPayment);
        }

        [Fact]
        public void PaymentForBookTest()
        {
            var processedPayment = _factory.GetPaymentResult(new BookPayment(20));
            var packingSlips = (processedPayment);
        }
    }
}
