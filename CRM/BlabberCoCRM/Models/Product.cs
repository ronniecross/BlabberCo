using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class Product
    {
        public int ID { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public ICollection<Conversation> Conversations { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
