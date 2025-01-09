using AsiaSushiOnCSharp.Domain.Entity.Base;

namespace AsiaSushiOnCSharp.Domain.Entity.Orders
{
    public class Order : BaseEntity
    {
        public Order() 
        {
            СreationDate = DateTime.Now;
        }

        // public required DateTime СreationDate { get; set; }

        /// <summary>
        /// Дата оформления заказа
        /// </summary>
        public required DateTime СreationDate { get; set; }

        // public User User { get; set; }

        /// <summary>
        /// Нужна ли доставка
        /// </summary>
        public required bool IsNeedDelivery { get; set; }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public required string DeliveryAddress { get; set; }

        /// <summary>
        /// Оплачен ли заказ
        /// </summary>
        public required bool IsPaid { get; set; }

        /// <summary>
        /// Оплатить при получении
        /// </summary>
        public required bool IsPaimentOnGet { get; set; }
    }
}
