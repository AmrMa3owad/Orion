using Orion.Models.Common;

namespace Orion.Models
{
    public class PreCommunity : BaseEntity<int>
    {
        public PreCommunity()
        {
            PremiumUsers = new HashSet<PremiumUser>();
        }

        public virtual ICollection<PremiumUser> PremiumUsers { get; set; }
    }
}
