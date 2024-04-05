using Orion.Models.Common;

namespace Orion.Models
{
    public class BoothOrder : BaseEntity<int> //Bridge
    {
        public int OrderId { get; set; }
        public int BoothId { get; set; }
        
        public virtual Order Order { get; set; }
        public virtual Booth Booth { get; set; }

    }
}
