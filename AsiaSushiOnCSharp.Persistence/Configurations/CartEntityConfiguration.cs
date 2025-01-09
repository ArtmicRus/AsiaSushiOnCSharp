using Microsoft.EntityFrameworkCore;
using AsiaSushiOnCSharp.Domain.Entity.Carts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class CartEntityConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            throw new NotImplementedException();
        }
    }
}
