using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlabberCoCRM.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public int PropertyNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostCode { get; set; }

        public ICollection<ClientEmployeeAddress> ClientEmployeeAddresses { get; set; }
        public Client Client { get; set; }
    }
}
