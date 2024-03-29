using Orion.Models.Common;

namespace Orion.Models
{
    public class Above12 : BaseEntity<int> , IFreelancer
    {
        public Above12()
        {
            Products = new HashSet<Product>();
        }
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
