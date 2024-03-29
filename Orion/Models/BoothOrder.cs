namespace Orion.Models
{
    public class BoothOrder : Order
    {
        public int BoothId { get; set; }
        public virtual Booth Booth { get; set; }

    }
}
