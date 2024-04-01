using Microsoft.AspNetCore.Identity;

namespace Orion.Models.Identity
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public Guid Id { get; set; }
    }
}
