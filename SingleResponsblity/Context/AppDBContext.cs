using Microsoft.EntityFrameworkCore;
using SingleResponsblity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SingleResponsblity.Context
{
    public class AppDBContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
     

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlServer(Configuration.GetConnectionString("SOLIDSRP"));
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
