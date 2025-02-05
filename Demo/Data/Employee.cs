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
        public int Id { get; set; }  //public numeric property named ass "Id" or "ClassNameId" will be considered as primary key Identity(1,1)
        public /*required*/ string? Name { get; set; }// Nullable Reference Type : Allows Null (Optional)
        public double Salary { get; set; } //Non-Nullable value type :Not allows null (Required)
        public int? Age { get; set; } // Nullable value Type :Allows Null (optional)
    }
}
