﻿namespace Orion.Models
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            CustomerProduct = new HashSet<CustomerProduct>();
        }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductColor { get; set; }
        public int ProductNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductSize { get; set; }
        public string Description { get; set; }
        public int ProductPrice { get; set; }
        public string Reviews { get; set; }
        public string Customization { get; set; }

        public virtual Supervisor Supervisor { get; set; }
        public virtual Above12 Above12 { get; set; }
        public virtual Above12 Event { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProduct { get; set; }

    }
}
