using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlabberCoCRM.Models
{
    public abstract class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }
    }
}
