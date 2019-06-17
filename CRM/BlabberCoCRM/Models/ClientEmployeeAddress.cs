using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class ClientEmployeeAddress
    {

        public Address Address { get; set; }
        [Key]
        public ClientEmployee ClientEmployee { get; set; }
    }
}
