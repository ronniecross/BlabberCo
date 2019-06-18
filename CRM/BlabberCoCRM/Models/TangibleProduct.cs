using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class TangibleProduct : Product
    {

        public string Manufacture { get; set; }
        public string Model { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "End of Sale")]
        public DateTime EndOfLife { get; set; }
    }
}
