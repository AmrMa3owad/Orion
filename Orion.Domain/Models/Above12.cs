using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Above12 : BaseEntity<int>
    {
        public Above12()
        {
            Products = new HashSet<Product>();
            FreelancerAbove12s = new HashSet<FreelancerAbove12>();
        }
        public virtual ICollection<FreelancerAbove12> FreelancerAbove12s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
