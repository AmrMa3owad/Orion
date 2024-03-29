namespace Orion.Models
{
    public class PremiumUser : BaseEntity<int>
    {
        public int Fees { get; set; }
        public virtual PreCommunity PreCommunity { get; set; }
    }
}
