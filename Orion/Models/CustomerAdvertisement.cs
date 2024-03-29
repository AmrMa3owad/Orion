namespace Orion.Models
{
    public class CustomerAdvertisement
    {
        public int CustomerId { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
