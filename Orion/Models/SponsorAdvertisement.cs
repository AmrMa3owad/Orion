using Orion.Models.Common;

namespace Orion.Models
{
    public class SponsorAdvertisement : BaseEntity<int>
    {
        public int SponsorId { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}
