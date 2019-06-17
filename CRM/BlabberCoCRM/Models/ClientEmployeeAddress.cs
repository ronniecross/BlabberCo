using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class ClientEmployeeAddress
    {

        public Address Address { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
