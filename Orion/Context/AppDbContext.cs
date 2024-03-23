using Microsoft.EntityFrameworkCore;
using Orion.Models;

namespace Orion.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }
    }
}
