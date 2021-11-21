using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models.Abstract
{
    public interface IProduct
    {
        Guid Id { get; set; }

        ISlip GenerateSlip();
    }
}
