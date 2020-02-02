using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Models
{
    public class Student
    {
       
        public int SId { get; set; }
        [Key]
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string SName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string SAddress { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string SEmail { get; set; }

        //Foreign key for Standard
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }


    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string StandardName { get; set; }
        [Column(TypeName = "nvarchar(4)")]
        public string StandardYear { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}

