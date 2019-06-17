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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TangibleProductId { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndOfLife { get; set; }
    }
}
