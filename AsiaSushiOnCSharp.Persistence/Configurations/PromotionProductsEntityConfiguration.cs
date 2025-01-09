using AsiaSushiOnCSharp.Domain.Entity.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class PromotionProductsEntityConfiguration : IEntityTypeConfiguration<PromotionProducts>
    {
        public void Configure(EntityTypeBuilder<PromotionProducts> builder)
        {
            throw new NotImplementedException();
        }
    }
}
