using Orion.Models.Common;

namespace Orion.Models
{
    public class Above12 : BaseFreelancer<int>
    {
        public Above12()
        {
            Products = new HashSet<Product>();
        }

        public virtual ICollection<Product> Products { get; set; }
    }
}
