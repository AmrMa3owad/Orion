namespace Orion.Models;

public class Role:BaseEntity
{
    public Role()
    {
        Users = new HashSet<User>();
        RolePermissions = new HashSet<RolePermission>();
    }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
    public virtual ICollection<User> Users { get; set; }
}