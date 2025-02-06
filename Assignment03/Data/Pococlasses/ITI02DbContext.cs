using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Data.Pococlasses
{
    internal class ITI02DbContext : DbContext
    {
        public ITI02DbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                   .UseSqlServer("Server =.;Database =ITI02;Trusted_Connection =True ; Encrypt =True;TrustServerCertificate =true");
        }
        public DbSet<Student>Students { get; set; }
        public DbSet<Course>Courses { get; set; }
      // public DbSet<Department>Departments { get; set; }
        public DbSet<Instructor>Instructors { get; set; }
       public DbSet<Course_Inst>Course_Insts { get; set; }
       public DbSet<Topic>Topics { get; set; }
       public DbSet<Stud_Course>Stude_Courses { get; set; }



    }
}
