using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    //Poco class
    //Plan old C#(CLR) object
    internal class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
    }
}
