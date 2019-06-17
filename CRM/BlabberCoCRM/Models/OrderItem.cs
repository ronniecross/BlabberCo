using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public DateTime WarrantyExpiry { get; set; }
        public int discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
