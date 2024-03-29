using Orion.Models.Common;

namespace Orion.Models
{
    public class BoothOrder : BaseEntity<int> , IOrder
    {
        public int BoothId { get; set; }
        public int OrderPrice { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
        public string OrderComments { get; set; }
        public virtual Booth Booth { get; set; }

    }
}
