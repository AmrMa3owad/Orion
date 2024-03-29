namespace Orion.Models
{
    public class Above12 : Freelancer
    {
        public Above12()
        {
            Products = new HashSet<Product>();
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}
