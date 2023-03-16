namespace CRUID_1.Models
{
    public class OrderItemModel
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

    }
}
