using Microsoft.AspNetCore.Identity;

namespace Orion.Models.Common;

public class User : IdentityUser<int>
{
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
}
