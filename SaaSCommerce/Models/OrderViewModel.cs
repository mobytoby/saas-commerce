using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaaSCommerce.Models
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}