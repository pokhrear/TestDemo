using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Models
{
    public class Operation
    {
        [Display(Name = "First Number")]
        public double Number1 { get; set; }
        [Display(Name = "First Number")]
        public double Number2 { get; set; }
        [Display(Name = "First Number")]
        public double Number3 { get; set; }
        [Display(Name = "First Number")]
        public double Number4 { get; set; }
        [Display(Name = "First Number")]
        public double Result { get; set; }
    }
}
