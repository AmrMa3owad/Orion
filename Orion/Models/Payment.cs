using Orion.Models.Common;

namespace Orion.Models
{
    public class Payment : BaseEntity<int>
    {
        public int PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
