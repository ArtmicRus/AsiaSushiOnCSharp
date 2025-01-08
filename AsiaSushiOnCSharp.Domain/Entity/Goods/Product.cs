using AsiaSushiOnCSharp.Domain.Entity.Base;

namespace AsiaSushiOnCSharp.Domain.Entity.Goods
{
    /// <summary>
    /// 
    /// </summary>
    public class Product : AuditableBaseEntity
    {
        public Product(List<Category> category)
        {
            Category = category;
        }

        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Discount { get; set; }
        List<Category> Category { get; set; }
    }
}