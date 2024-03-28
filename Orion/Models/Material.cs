namespace Orion.Models
{
    public class Material : BaseEntity<int>
    {
        public string MaterialType { get; set; }
        public int MaterialPrice { get; set; }
        public int MaterialQuantity { get; set; }
    }
}
