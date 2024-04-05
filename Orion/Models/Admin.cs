using Orion.Models.Common;

namespace Orion.Models
{
    public class Admin : BaseEmployee<int>
    {
        public Admin()
        {
            Feedbacks = new HashSet<Feedback>();
        }
        public int WebsiteId { get; set; }
        public int DeviceId { get; set; }
   
        public virtual Website Website { get; set; }
        public virtual Device Device { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
