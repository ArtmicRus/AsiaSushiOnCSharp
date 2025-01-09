using AsiaSushiOnCSharp.Domain.Entity.Feedback;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaSushiOnCSharp.Persistence.Configurations
{
    internal class ReviewEntityConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            throw new NotImplementedException();
        }
    }
}
