using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApi
{
    public class CalcRequest
    {
        [Required(ErrorMessage = "Num1 is required")]
        [RegularExpression(@"^\d*\.?\d*$", ErrorMessage = "Num1 must be a number")]
        public double Num1 { get; set; }
        [Required(ErrorMessage = "Num2 is required")]
        [RegularExpression(@"^\d*\.?\d*$", ErrorMessage = "Num2 must be a number")]
        public double Num2 { get; set; }
        public string Operation { get; set; }
    }
}
