﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}