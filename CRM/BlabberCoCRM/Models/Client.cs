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
        public int ID { get; set; }
        public string nNme { get; set; }
        [DataType(DataType.Date)]
        public DateTime SetupDate { get; set; }
        public string CostCenterCode { get; set; }

        public int AddressID { get; set; }
        [Required]
        public Address Address { get; set; }
        public ICollection<ClientToEmployee> ClientToEmployees { get; set; }
        public PrimaryClientEmployee PrimaryClientEmployee { get; set; }

    }
}
