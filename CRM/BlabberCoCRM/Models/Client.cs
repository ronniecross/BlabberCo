using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string nNme { get; set; }
        [DataType(DataType.Date)]
        public DateTime SetupDate { get; set; }
        public string CostCenterCode { get; set; }

        public Address Address { get; set; }
        public int AddressId { get; set; }
        public ICollection<ClientToEmployee> ClientToEmployees { get; set; }
        public PrimaryClientEmployee PrimaryClientEmployee { get; set; }

    }
}
