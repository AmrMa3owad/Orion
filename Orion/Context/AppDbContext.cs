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

        public DbSet<Test> ests { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }
    }
}
