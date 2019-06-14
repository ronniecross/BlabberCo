using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlabberCoCRM.Models;

namespace BlabberCoCRM.Models
{
    public class CRMContext : DbContext
    {
        public CRMContext (DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public DbSet<BlabberCoCRM.Models.Address> Address { get; set; }

        public DbSet<BlabberCoCRM.Models.Client> Client { get; set; }
    }
}
