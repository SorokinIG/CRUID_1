using Microsoft.EntityFrameworkCore;
using CRUID_1.Models;

namespace CRUID_1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<OrderModel> Order { get; set; } = null!;
        public DbSet<OrderItemModel> OrderItem { get; set; } = null!;
        public DbSet<ProviderModel> Provider { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderModel>().ToTable("Order");
            modelBuilder.Entity<OrderItemModel>().ToTable("OrderItem");
            modelBuilder.Entity<ProviderModel>().ToTable("Provider");
        }


    }
}
