namespace Orion.Models
{
    public class Above12 : BaseEntity<int>
    {
        public Above12()
        {
            Product = new HashSet<Product>();
        }

        public virtual ICollection<Product> Product { get; set; }
    }
}
