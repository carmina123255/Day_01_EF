﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Data.Pococlasses
{
    internal class Stud_Course
    {
        [Key]
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }  
        public int Grade {  get; set; } 
    }
}
