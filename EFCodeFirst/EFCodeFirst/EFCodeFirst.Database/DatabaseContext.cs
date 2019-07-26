using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>(entity => entity.HasOne(t => t.ModuleConfiguration).WithOne(mc => mc.Tenant).HasForeignKey<ModuleConfiguration>(mc => mc.Id));

        }
    }
}
