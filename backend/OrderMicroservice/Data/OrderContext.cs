using Microsoft.EntityFrameworkCore;
using OrderMicroservice.Models;

namespace OrderMicroservice.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the one-to-many relationship
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            // Seed data (optional)
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1 } // No OrderDate
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, ProductId = 1, Quantity = 2, OrderId = 1 },
                new OrderItem { Id = 2, ProductId = 2, Quantity = 1, OrderId = 1 }
            );
        }
    }
}