using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    internal class PhysicalProductFactory : IProductFactory
    {
        public IPaymentResult CreateProduct(int amount)
        {
            if (amount > 0)
                return new PackingSlip("shipping");

            return null;
        }
    }
}
