using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUID_1.Models
{
    public class MainViewModel
    {
        /// <summary>
        /// Список заказов
        /// </summary>
        public IEnumerable<OrderModel>? Orders { get; set; }
        /// <summary>
        /// Подробнее о заказе
        /// </summary>
        public IEnumerable<OrderItemModel>? OrderItems { get; set; }
        /// <summary>
        /// Список поставщиков
        /// </summary>
        public List<SelectListItem> Providers   { get; set; }
        /// <summary>
        /// Дата начала для фильтра
        /// </summary>
        [BindProperty, DataType(DataType.Date)]
        public DateTime Date_Start
        {
            get
            {
                return this.date_Start.HasValue
                   ? this.date_Start.Value
                   : DateTime.Now.AddMonths(-1);
            }

            set { this.date_Start = value; }
        }

        private DateTime? date_Start = null;
        /// <summary>
        /// Дата конца для фильтра
        /// </summary>
        [BindProperty, DataType(DataType.Date)]
        public DateTime Date_End
        {
            get
            {
                return this.date_End.HasValue
                   ? this.date_End.Value
                   : DateTime.Now;
            }
            set { this.date_End = value; }
        }

        private DateTime? date_End = null;
        public string SelectedValues { get; set; }
    }
}
