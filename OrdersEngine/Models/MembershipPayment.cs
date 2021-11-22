using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class MembershipPayment : IProduct
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }

        public MembershipPayment(int amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
        }
    }
}
