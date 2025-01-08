using AsiaSushiOnCSharp.Domain.Entity.Goods;
using Microsoft.EntityFrameworkCore;

namespace AsiaSushiOnCSharp.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; }

        DbSet<Category> Categories { get; }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}