﻿using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class PhysicalProductFactory : IProductFactory
    {
        const int COMMISION = 2;
        public IPaymentResult CreateProduct(int amount)
        {
            if (GenerateCommision(amount) > 0)
                return GenerateProduct();

            return null;
        }

        private int GenerateCommision(int amount) => amount - COMMISION;
        public virtual IPaymentResult GenerateProduct() => new PackingSlip(PaymentResultEnum.Shipping);
    }
}
