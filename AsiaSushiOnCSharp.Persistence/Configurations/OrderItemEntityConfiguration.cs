using AsiaSushiOnCSharp.Domain.Entity.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class OrderItemEntityConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            throw new NotImplementedException();
        }
    }
}
