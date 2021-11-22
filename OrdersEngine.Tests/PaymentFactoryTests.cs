using OrdersEngine.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace OrdersEngine.Tests
{
    public class PaymentFactoryTests
    {
        [Theory]
        [InlineData(100)]
        public void PaymentForPhysicalProductTest(int amount)
        {
            var factory = new PhysicalProductFactory();
            var processedPayment = factory.CreateProduct(amount);
            Assert.NotNull(processedPayment);
            Assert.Equal(Models.Abstract.PaymentResultEnum.Shipping, processedPayment.Goal);
        }

        [Theory]
        [InlineData(100)]
        public void PaymentForBookTest(int amount)
        {
            var factory = new BookFactory();
            var processedPayment = factory.CreateProduct(amount);
            Assert.NotNull(processedPayment);
            Assert.True(processedPayment.Goal.HasFlag(Models.Abstract.PaymentResultEnum.Shipping));
            Assert.True(processedPayment.Goal.HasFlag(Models.Abstract.PaymentResultEnum.RoyaltyDep));
        }
        
        [Theory]
        [InlineData(100)]
        public void PaymentForBookTest(int amount)
        {
            var factory = new BookFactory();
            var processedPayment = factory.CreateProduct(amount);
            Assert.NotNull(processedPayment);
            Assert.True(processedPayment.Goal.HasFlag(Models.Abstract.PaymentResultEnum.Shipping));
            Assert.True(processedPayment.Goal.HasFlag(Models.Abstract.PaymentResultEnum.RoyaltyDep));
        }
    }
}
