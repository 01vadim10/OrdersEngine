using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models.Abstract
{
    public interface IProductFactory
    {
        IPaymentResult CreateProduct(int amount);
        IPaymentResult GenerateProduct();
    }
}
