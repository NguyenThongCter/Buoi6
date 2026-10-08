using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Baitap1
{
    public class Student
    {
        public int Id { get; set; }
        [Column("Name")]
        public string FullName { get; set; } = string.Empty;
        [Column("Score")]
        public double Grade { get; set; }
    }
}