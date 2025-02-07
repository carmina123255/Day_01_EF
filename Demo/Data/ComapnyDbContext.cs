using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class ComapnyDbContext:DbContext
    {
        public  ComapnyDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server =.;Database =Company;Trusted_Connection =True ; Encrypt =True;TrustServerCertificate =true");

        }
        public DbSet<Employee>? Employees { get; set; }
        
        //public DbSet<Product>? Products { get; set; }
       // public DbSet<Project>? Projects { get; set; }


      
    }
}

