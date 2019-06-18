using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class ServiceProduct : Product
    {
        public String Summary { get; set; }
        [Display(Name ="Duration (Days)")]
        public int DurationDays { get; set; }
    }
}
