using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class ItiDbContext:DbContext
    {
        public ItiDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server =.;Database =Iti;Trusted_Connection =True ; Encrypt =True;TrustServerCertificate =true");
        }
        public DbSet<Student>? students { get; set; }
    }
}
