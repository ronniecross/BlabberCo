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

        public DbSet<BlabberCoCRM.Models.ClientService> ClientService { get; set; }

        public DbSet<BlabberCoCRM.Models.Communication> Communication { get; set; }

        public DbSet<BlabberCoCRM.Models.Conversation> Conversation { get; set; }

        public DbSet<BlabberCoCRM.Models.CSOEmployee> CSOEmployee { get; set; }

        public DbSet<BlabberCoCRM.Models.SalesEmployee> SalesEmployee { get; set; }

        public DbSet<BlabberCoCRM.Models.ClientEmployee> ClientEmployee { get; set; }

        public DbSet<BlabberCoCRM.Models.Order> Order { get; set; }

        public DbSet<BlabberCoCRM.Models.OrderItem> OrderItem { get; set; }

        public DbSet<BlabberCoCRM.Models.ServiceProduct> ServiceProduct { get; set; }

        public DbSet<BlabberCoCRM.Models.TangibleProduct> TangibleProduct { get; set; }

        public DbSet<BlabberCoCRM.Models.Product> Product { get; set; }

        public DbSet<BlabberCoCRM.Models.InternalEmployee> InternalEmployee { get; set; }
    }
}
