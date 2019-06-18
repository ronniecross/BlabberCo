using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Order Date")]
        public DateTime OrderDate { get; set; }
        public int Discount { get; set; }
        
        public ICollection<OrderItem> OrderItems { get; set; }
        public SalesEmployee SalesEmployee { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
