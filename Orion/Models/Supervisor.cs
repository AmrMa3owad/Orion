namespace Orion.Models
{
    public class Supervisor: BaseEntity<int>
    {
        public Supervisor()
        {
            Under12 = new HashSet<Under12>();
            Product = new HashSet<Product>();
        }
        public virtual ICollection<Under12> Under12 { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
