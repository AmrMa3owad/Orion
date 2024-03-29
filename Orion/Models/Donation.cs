using Orion.Models.Enums;

namespace Orion.Models
{
    public class Donation : BaseEntity<int>
    {
        public Donation()
        {
            Sponsor = new HashSet<Sponsor>();
        }
        public DonationType DonationType { get; set; }
        public double DonationQuantity { get; set; }
        public DateTime DonationTime { get; set; }
        public string DonationMethod { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Sponsor> Sponsor { get; set; }
    }
}
