﻿using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class PackingSlip : ISlip
    {
        public Guid Id { get; set; }
        public PaymentResultEnum Goal { get; set; }

        public PackingSlip(PaymentResultEnum goal)
        {
            Goal = goal;
        }
    }
}
