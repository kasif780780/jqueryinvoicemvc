using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string OrderDate { get; set; }
        public string Address { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}