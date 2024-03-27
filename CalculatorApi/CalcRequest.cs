using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApi
{
    public class CalcRequest
    {
        [Required(ErrorMessage = "Number1 is required")]
        [RegularExpression(@"^-?\d*\.{0,1}\d+$", ErrorMessage = "Number1 must be a number")]
        public string Num1 { get; set; }
        [Required(ErrorMessage = "Number2 is required")]
        [RegularExpression(@"^-?\d*\.{0,1}\d+$", ErrorMessage = "Number2 must be a number")]
        public string Num2 { get; set; }
        [RegularExpression(@"^[\+\-\*\/]$", ErrorMessage = "Invalid operation. Allowed operations are +, -, *, /")]
        public string Operation { get; set; }
    }
}
