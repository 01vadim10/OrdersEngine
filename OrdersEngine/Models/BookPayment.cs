using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class BookPayment : IProduct
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BookPayment(int amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
        }
    }
}
