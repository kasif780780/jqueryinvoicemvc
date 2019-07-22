using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Cutomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual IList<Order> Orders { get; set; }
      
    }
}