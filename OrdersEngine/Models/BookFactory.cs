using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class BookFactory : IProductFactory
    {
        public IPaymentResult CreateProduct(int amount)
        {
            if (amount > 0)
            {
                PaymentResultEnum result = PaymentResultEnum.Shipping | PaymentResultEnum.RoyaltyDep;
                return new PackingSlip(result);
            }

            return null;
        }
    }
}
