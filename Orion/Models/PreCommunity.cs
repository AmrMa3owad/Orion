namespace Orion.Models
{
    public class PreCommunity : BaseEntity<int>
    {
        public PreCommunity()
        {
            PremiumUser = new HashSet<PremiumUser>();
        }

        public virtual ICollection<PremiumUser> PremiumUser { get; set; }
    }
}
