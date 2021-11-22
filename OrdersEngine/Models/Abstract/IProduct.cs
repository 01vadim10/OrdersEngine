using System;

namespace OrdersEngine.Models.Abstract
{
    public interface IProduct
    {
        Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
