using Orion.Models.Common;

namespace Orion.Models
{
    public class Order : BaseEntity<int>
    {
        
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
        public string OrderComments { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
