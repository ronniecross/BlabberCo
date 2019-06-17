using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class Communication
    {
        public enum EComType
        {
            phone,
            email
        };
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public EComType ComType { get; set; }
        public Conversation Conversation { get; set; }
    }
}
