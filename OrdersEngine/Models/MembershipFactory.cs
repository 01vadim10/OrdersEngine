using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class MembershipFactory : IProductFactory
    {
        public IPaymentResult CreateProduct(int amount)
        {
            if (amount > 0) {
                var membership = new Membership(PaymentResultEnum.Activate);
                return membership.Execute("user@test.com");
            }

            return null;
        }
    }
}
