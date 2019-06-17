using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class PrimaryClientEmployee
    {
        [Key]
        public Client Client { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
