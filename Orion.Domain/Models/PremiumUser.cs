using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class PremiumUser : BaseEntity<int>
    {
        public PremiumUser()
        {
            UserPremiumUsers = new HashSet<UserPremiumUser>();

        }
        public int Fees { get; set; }
        public int PreCommunityId { get; set; }

        public virtual PreCommunity PreCommunity { get; set; }
        public virtual ICollection<UserPremiumUser> UserPremiumUsers { get; set; }

    }
}
