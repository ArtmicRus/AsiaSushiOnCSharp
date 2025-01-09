using AsiaSushiOnCSharp.Domain.Entity.Base;
using AsiaSushiOnCSharp.Domain.Entity.Goods;

namespace AsiaSushiOnCSharp.Domain.Entity.Carts
{
    public class CartItem : BaseEntity
    {
        public CartItem(Cart cart, Product product)
        {
            Cart = cart;
            Product = product;
        }

        public Cart Cart { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
