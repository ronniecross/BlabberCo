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
        public string ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date), Display(Name="Setup Date")]
        public DateTime SetupDate { get; set; }
        [Display(Name="Cost Center Code")]
        public string CostCenterCode { get; set; }
        public ICollection<ClientToEmployee> ClientToEmployees { get; set; }
        public int? PrimaryClientEmployeeId { get; set; }
        public PrimaryClientEmployee PrimaryClientEmployee { get; set; }

    }
}
