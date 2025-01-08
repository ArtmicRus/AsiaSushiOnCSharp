using AsiaSushiOnCSharp.Domain.Entity.Base;

namespace AsiaSushiOnCSharp.Domain.Entity.Goods
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
    }
}
