using Orion.Models.Common;

namespace Orion.Models
{
    public class Supervisor: BaseEmployee<int>
    {
        public Supervisor()
        {
            Under12s = new HashSet<Under12>();
            Products = new HashSet<Product>();
        }
        
        public virtual ICollection<Under12> Under12s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
