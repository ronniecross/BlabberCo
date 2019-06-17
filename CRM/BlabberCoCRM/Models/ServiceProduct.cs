using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class ServiceProduct : Product
    {
        public int ServiceProductId { get; set; }
        public String Summary { get; set; }
        public int DurationDays { get; set; }
    }
}
