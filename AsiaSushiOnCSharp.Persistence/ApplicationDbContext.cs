using AsiaSushiOnCSharp.Application.Interfaces;
using AsiaSushiOnCSharp.Domain.Entity.Carts;
using AsiaSushiOnCSharp.Domain.Entity.Feedback;
using AsiaSushiOnCSharp.Domain.Entity.Goods;
using AsiaSushiOnCSharp.Domain.Entity.Orders;
using AsiaSushiOnCSharp.Domain.Entity.Promotions;
using AsiaSushiOnCSharp.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AsiaSushiOnCSharp.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=WorkKursDatabase;Username=worker;Password=worker");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CartEntityConfiguration().Configure(modelBuilder.Entity<Cart>());
            new CartItemEntityConfiguration().Configure(modelBuilder.Entity<CartItem>());
            new CategoryEntityConfiguration().Configure(modelBuilder.Entity<Category>());
            new OrderEntityConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderItemEntityConfiguration().Configure(modelBuilder.Entity<OrderItem>());
            new ProductEntityConfiguration().Configure(modelBuilder.Entity<Product>());
            new PromotionEntityConfiguration().Configure(modelBuilder.Entity<Promotion>());
            new PromotionProductsEntityConfiguration().Configure(modelBuilder.Entity<PromotionProducts>());
            new ReviewEntityConfiguration().Configure(modelBuilder.Entity<Review>());
        }
    }
}
