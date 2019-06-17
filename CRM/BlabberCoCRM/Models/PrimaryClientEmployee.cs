using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class PrimaryClientEmployee
    {
        public Client Client { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
