
namespace Orion.Models;

public class Permission:BaseEntity
{
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
}