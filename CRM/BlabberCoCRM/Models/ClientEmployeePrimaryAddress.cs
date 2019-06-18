using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class ClientEmployeePrimaryAddress
    {
        public int ID { get; set; }
        public int ClientEmployeeId { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
        public int? ClientEmployeeAddressId { get; set; }
        public ClientEmployeeAddress ClientEmployeeAddress { get; set; }

    }
}
