namespace Orion.Models
{
    public class Freelancer : BaseEntity<int>
    {
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }
    }
}
