using Microsoft.EntityFrameworkCore;
using Orion.Models;
using Orion.Models.Common;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }
    }
}
