using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Orion.Models.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}