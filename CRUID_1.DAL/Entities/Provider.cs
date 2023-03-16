using System.Collections.Generic;

namespace CRUID_1.DAL.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        /// <summary>
        /// используется для фильтрации
        /// </summary>
        public string? Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
