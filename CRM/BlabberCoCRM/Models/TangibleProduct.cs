using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class TangibleProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndOfLife { get; set; }
    }
}
