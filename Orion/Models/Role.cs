namespace Orion.Models;

public class Role:BaseEntity<int>
{
    public Role()
    {
        Users = new HashSet<User>();
        RolePermissions = new HashSet<RolePermission>();
    }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
    public virtual ICollection<User> Users { get; set; }
}