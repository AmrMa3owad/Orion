using Orion.Models.Common;

namespace Orion.Models
{
    public class Event : BaseEntity<int>
    {
        public Event()
        {
            Products = new HashSet<Product>();
            Sponsors = new HashSet<Sponsor>();
            Customers = new HashSet<Customer>();
        }
        public DateTime EventDate { get; set; }
        public string EventTitle { get; set; }
        public string EventPlace { get; set; }
        public int BoothId { get; set; }
        public virtual Booth Booth { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
