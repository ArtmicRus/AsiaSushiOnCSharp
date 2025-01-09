using AsiaSushiOnCSharp.Domain.Entity.Carts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class CartItemEntityConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            throw new NotImplementedException();
        }
    }
}
