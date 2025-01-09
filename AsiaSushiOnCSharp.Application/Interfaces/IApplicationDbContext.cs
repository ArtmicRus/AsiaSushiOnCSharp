using AsiaSushiOnCSharp.Domain.Entity.Carts;
using AsiaSushiOnCSharp.Domain.Entity.Feedback;
using AsiaSushiOnCSharp.Domain.Entity.Goods;
using AsiaSushiOnCSharp.Domain.Entity.Orders;
using AsiaSushiOnCSharp.Domain.Entity.Promotions;
using Microsoft.EntityFrameworkCore;

namespace AsiaSushiOnCSharp.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Cart> Carts { get; }
        DbSet<CartItem> CartItems { get; }
        DbSet<Review> Reviews { get; }
        DbSet<Order> Orders { get; }
        DbSet<OrderItem> OrderItems { get; }
        DbSet<Promotion> Promotions { get; }
        DbSet<Product> Products { get; }

        DbSet<Category> Categories { get; }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}