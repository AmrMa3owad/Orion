namespace Orion.Models
{
    public class Booth : BaseEntity<int>
    {
        public Booth()
        {
            BoothOrder = new HashSet<BoothOrder>();
        }
        public int BoothNumber { get; set; }
        public int BoothCapacity { get; set; }

        public virtual ICollection<BoothOrder> BoothOrder { get; set; }
        public virtual Event Event { get; set; }

    }
}
