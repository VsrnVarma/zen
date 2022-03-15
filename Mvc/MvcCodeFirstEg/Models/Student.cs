using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCodeFirstEg.Models
{
    [Table("TblStudent")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public int Percentage { get; set; }
    }
}