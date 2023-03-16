using System.Collections.Generic;

namespace CRUID_1.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }

        /// <summary>
        /// используется для фильтрации
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        public int ProviderId { get; set; }

        public Provider Provider { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}