using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class BookFactory : PhysicalProductFactory
    {
        public override IPaymentResult GenerateProduct(string details)
        {
            PaymentResultEnum result = PaymentResultEnum.Shipping | PaymentResultEnum.RoyaltyDep;
            return new PackingSlip<ProductOfPayment>(result, new ProductOfPayment());
        }
    }
}
