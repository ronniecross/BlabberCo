using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class ClientEmployeeAddress
    {
        public int Id { get; set; }
        public int ClientEmployeeId { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
        public int AddressID { get; set; }
        public Address Address { get; set; }
        
    }
}
