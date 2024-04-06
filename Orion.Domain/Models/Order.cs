using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Order : BaseOrder<int>
    {
        public Order()
        {
            BoothOrders = new HashSet<BoothOrder>();
            DeliveryOrders = new HashSet<DeliveryOrder>();
        }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<BoothOrder> BoothOrders { get; set; }
        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set;}
    }
}
