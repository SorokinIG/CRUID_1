using System.Collections.Generic;

namespace CRUID_1.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        /// <summary>
        /// Id заказа
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// название 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// количество
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// ед. измерения
        /// </summary>
        public string Unit { get; set; }

        public Order Order { get; set; }
    }
}
