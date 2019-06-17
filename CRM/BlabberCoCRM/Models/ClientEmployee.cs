using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class ClientEmployee : Person
    {
        public int Id { get; set; }

        public ICollection<ClientEmployeeAddress> ClientEmployeeAddresses { get; set; }
        public Address PrimaryAddress { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Conversation> Conversations { get; set; }
        public Client Client { get; set; }
    }
}
