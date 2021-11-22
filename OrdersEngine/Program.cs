using OrdersEngine.Models;
using System;

namespace OrdersEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new PaymentFactory();
            var result = factory.GetPaymentResult();
            Console.WriteLine($"Result id: {result.Id}");
        }
    }
}
