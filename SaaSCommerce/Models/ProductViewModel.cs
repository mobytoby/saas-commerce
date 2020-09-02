using System.Collections.Generic;

namespace SaaSCommerce.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}