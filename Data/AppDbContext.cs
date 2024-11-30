using Microsoft.EntityFrameworkCore;
using single_api.Models;

namespace single_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(o => o.LastChanged)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Order>()
                .HasIndex(o => new {o.Id, o.LastChanged });

        }
    }
}
