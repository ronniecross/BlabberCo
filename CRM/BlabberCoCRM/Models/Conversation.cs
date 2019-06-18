using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public class Conversation
    {
        public enum Status
        {
            Open,
            Closed,
            OnHold
        };
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        [Display(Name ="Status")]
        public Status status { get; set; }
        [Display(Name ="Opened")]
        public DateTime OpenDateTime { get; set; }
        [Display(Name ="Closed")]
        public DateTime CloseDateTime { get; set; }

        public ICollection<Communication> Communications { get; set; }
        public Product Product { get; set; }
        public InternalEmployee InternalEmployee { get; set; }
        public ClientEmployee ClientEmployee { get; set; }
    }
}
