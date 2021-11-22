using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models.Abstract
{
    [Flags]
    public enum PaymentResultEnum
    {
        Shipping   = 0b_0000_0000,
        RoyaltyDep = 0b_0000_0001,
        Activate   = 0b_0000_0010,
        Upgrade    = 0b_0000_0100,
        Video      = 0b_0000_1000
    }

    public interface IPaymentResult
    {
        Guid Id { get; set; }
        PaymentResultEnum Goal { get; set; }
    }
}
