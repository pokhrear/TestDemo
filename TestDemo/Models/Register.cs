using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Models
{
    public class Register
    {

      
       [Key]
       [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Email { get; set; }
        
       [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",
            ErrorMessage ="Password and cnofirmation password do not match !")]
        public string Confirm_Password { get; set; }

       }
}
