namespace Orion.Models
{
    public class SponsorAdvertisement
    {
        public int SponsorId { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}
