using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class UpgradeMembershipFactory : MembershipFactory
    {
        public override IPaymentResult GenerateProduct(string details) => new Membership(PaymentResultEnum.Upgrade);
    }
}
