namespace Orion.Models
{
    public class Booth : BaseEntity<int>
    {
        public int BoothNumber { get; set; }
        public int BoothCapacity { get; set; }
    }
}
