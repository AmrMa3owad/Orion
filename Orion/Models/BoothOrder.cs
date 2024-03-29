namespace Orion.Models
{
    public class BoothOrder : BaseEntity<int>
    {
        public virtual Booth Booth { get; set; }

    }
}
