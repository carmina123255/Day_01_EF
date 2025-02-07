using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    //Poco class
    //Plan old C#(CLR) object

    //1-Convention 
    /// internal class Employee
    /// {
    ///     public int Id { get; set; }  //public numeric property named ass "Id" or "ClassNameId" will be considered as primary key Identity(1,1)
    ///     public /*required*/ string? Name { get; set; }// Nullable Reference Type : Allows Null (Optional)
    ///     public double Salary { get; set; } //Non-Nullable value type :Not allows null (Required)
    ///     public int? Age { get; set; } // Nullable value Type :Allows Null (optional)
    /// }
    /// 

    //2-Data Annotation 
   // [Table("Emp",Schema ="HR")] 
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }  //public numeric property named ass "Id" or "ClassNameId" will be considered as primary key Identity(1,1)
        [Required(ErrorMessage ="Name is Requied")]
        [Column(TypeName ="varchar")]
      //  [StringLength(50,MinimumLength =10)]
        [MaxLength(50)]
       // [MinLength(10)]
       // [Length(10,20)]
        public /*required*/ string? Name { get; set; }// Nullable Reference Type : Allows Null (Optional)
        [Column(TypeName ="decimal(20,10)")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; } //Non-Nullable value type :Not allows null (Required)
        [Range(20,23)]
        [AllowedValues(20,40,60)]
        [DeniedValues(12,14)]
        public int? Age { get; set; } // Nullable value Type :Allows Null (optional)

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string? Password;
        [NotMapped]
        public double netSalary { get
            {
                return (Salary - (Salary * 0.2));
            }
        }

    }
}
