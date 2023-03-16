

namespace CRUID_1.Models
{
    
    public class OrderModel
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
    }
}
