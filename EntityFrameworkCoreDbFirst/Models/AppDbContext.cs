using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreDbFirst.Models {
    
    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if(!builder.IsConfigured) {
                builder.UseSqlServer(
                    "server=localhost\\sqlexpress;"
                    + "database=SalesDbMax;"
                    + "trusted_connection=true;"
                );
            }
        }
    }
}
