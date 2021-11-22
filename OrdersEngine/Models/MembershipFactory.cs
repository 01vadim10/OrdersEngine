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
        public IPaymentResult CreateProduct(int amount, string details = "")
        {
            if (amount > 0) {
                Membership membership = (Membership)GenerateProduct(details);
                return membership.Execute("user@test.com");
            }

            return null;
        }

        public virtual IPaymentResult GenerateProduct(string details) => new Membership(PaymentResultEnum.Activate);
    }
}
