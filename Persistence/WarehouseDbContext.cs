using Microsoft.EntityFrameworkCore;
using SharedContracts.DataContracts;

namespace Persistence
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Employment>().ToTable("Employment");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
