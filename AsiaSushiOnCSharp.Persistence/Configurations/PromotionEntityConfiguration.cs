using AsiaSushiOnCSharp.Domain.Entity.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class PromotionEntityConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            throw new NotImplementedException();
        }
    }
}
