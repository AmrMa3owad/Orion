using Microsoft.AspNetCore.Identity;

namespace Orion.Models
{
    public class PremiumUser : IdentityUser<int>
    {
        public int Fees { get; set; }
        public int PreCommunityId { get; set; }

        public virtual PreCommunity PreCommunity { get; set; }
    }
}
