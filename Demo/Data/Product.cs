using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class Product
    {
        [Key]
        public int Code { get; set; }
        public required string NameAr {  get; set; }
        public required string NameEn { get; set; }
        public double UnitPrice { get; set; }
    }
}
