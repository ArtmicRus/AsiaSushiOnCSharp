using AsiaSushiOnCSharp.Application.Interfaces;
using AsiaSushiOnCSharp.Domain.Entity.Goods;
using Microsoft.EntityFrameworkCore;

namespace AsiaSushiOnCSharp.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
