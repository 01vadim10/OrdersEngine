﻿using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class VideoProductOfPayment : ISlipType
    {
        public string ExtraVideo { get; set; }
    }
}
