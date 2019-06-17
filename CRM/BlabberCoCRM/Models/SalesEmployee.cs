﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlabberCoCRM.Models
{
    public class SalesEmployee : InternalEmployee
    {
        public int Id { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
