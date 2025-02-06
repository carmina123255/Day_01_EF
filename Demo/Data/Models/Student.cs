using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public required string FName { get; set; }
        public required string LName { get; set; }
        public string? Address { get; set; }
        public decimal Age { get; set; }
        public int Dep_Id { get; set; }

    }
}
