namespace Orion.Models;

public class User:BaseEntity
{
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }
}
