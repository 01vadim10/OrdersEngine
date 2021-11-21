using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class PhysicalProduct : IProduct
    {
        public Guid Id { get; set; }

        public PhysicalProduct()
        {
            Id = Guid.NewGuid();
        }

        public void GenerateSlip()
        {
            throw new NotImplementedException();
        }
    }
}
