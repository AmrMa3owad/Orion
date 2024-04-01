using Microsoft.AspNetCore.Identity;

namespace Orion.Models.Identity
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public Guid Id { get; set; }
    }
}
