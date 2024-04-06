using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
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
