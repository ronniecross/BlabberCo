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
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int ClientEmployeeID { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
