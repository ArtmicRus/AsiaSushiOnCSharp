using AsiaSushiOnCSharp.Domain.Entity.Base;
using AsiaSushiOnCSharp.Domain.Entity.Goods;

namespace AsiaSushiOnCSharp.Domain.Entity.Promotions
{
    public class PromotionProducts : BaseEntity
    {
        public PromotionProducts(Promotion promotion, Product product) 
        {
            Promotion = promotion;
            Product = product;
        }

        public Promotion Promotion { get; }
        public Product Product { get; }
    }
}
