using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class PhysicalProductFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new PhysicalProduct();
        }
    }
}
