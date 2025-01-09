using AsiaSushiOnCSharp.Domain.Entity.Base;
using AsiaSushiOnCSharp.Domain.Entity.Goods;

namespace AsiaSushiOnCSharp.Domain.Entity.Orders
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(Order order, Product product, decimal price)
        {
            Order = order;
            Product = product;
            Price = price;
        }

        /// <summary>
        /// Заказ
        /// </summary>
        public Order Order { get; }

        /// <summary>
        /// Товар
        /// </summary>
        public Product Product { get; }

        /// <summary>
        /// Цена на момент заказа
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Количество товара
        /// </summary>
        public int Quantity { get; set; }


    }
}
