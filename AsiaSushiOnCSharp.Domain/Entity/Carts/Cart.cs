using AsiaSushiOnCSharp.Domain.Entity.Base;
using AsiaSushiOnCSharp.Domain.Entity.Promotions;

namespace AsiaSushiOnCSharp.Domain.Entity.Carts
{
    /// <summary>
    /// Корзина пользователя
    /// </summary>
    public class Cart : BaseEntity
    {
        public Promotion? Promotion { get; set; }

        // public User User { get; set; } 123
    }
}
