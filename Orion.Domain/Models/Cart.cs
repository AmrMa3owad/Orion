﻿using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Cart : BaseEntity<int>
    {
        public Cart()
        {
            Products = new HashSet<Product>();
        }
        public int? NumberOfProducts { get; set; }
        public double? TotalPrice { get; set; }

        public virtual ICollection<Product> Products { get; set;}
    }
}