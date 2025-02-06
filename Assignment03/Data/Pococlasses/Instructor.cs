using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Data.Pococlasses
{
    internal class Instructor
    {
        public int Id { get; set; }
        public required string Name { get; set; }   
        public double Bonous { get; set; }
        public double Salary { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }
        public int dept_Id { get; set; }
    }
}
