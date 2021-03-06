using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models.Abstract
{
    public interface IMembership : IPaymentResult
    {
        IPaymentResult Execute(string email);
        void SendEmail(string email);
    }
}
