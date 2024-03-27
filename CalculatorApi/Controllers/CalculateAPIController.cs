using CalculatorApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateAPIController : ControllerBase
    {        

        [HttpPost("Add")]
        public JsonResult Add([FromBody] CalcRequest requestData)
        {            
                try
                {
                    return new JsonResult(Ok(Convert.ToDecimal(requestData.Num1) + Convert.ToDecimal(requestData.Num2)));
                }
                catch (Exception ex)
                {
                    return new JsonResult(NotFound(ex.Message));
                }           


        }
        [HttpPost("Sub")]
        public JsonResult Subtract([FromBody] CalcRequest requestData)
        {
            try
            {
                return new JsonResult(Ok(Convert.ToDecimal(requestData.Num1) - Convert.ToDecimal(requestData.Num2)));
            }
            catch (Exception ex)
            {
                return new JsonResult(NotFound(ex.Message));
            }


        }
        [HttpPost("Mul")]
        public JsonResult Multiply([FromBody] CalcRequest requestData)
        {
            try
            {
                return new JsonResult(Ok(Convert.ToDecimal(requestData.Num1) * Convert.ToDecimal(requestData.Num2)));
            }
            catch (Exception ex)
            {
                return new JsonResult(NotFound(ex.Message));
            }


        }
        [HttpPost("Div")]
        public IActionResult Divide([FromBody] CalcRequest requestData)
        {
            try
            {
                if (Convert.ToDecimal(requestData.Num2) == 0)
                {
                    return BadRequest("Division by zero is not allowed");
                }
                return new JsonResult(Ok(Convert.ToDecimal(requestData.Num1) / Convert.ToDecimal((requestData.Num1))));
            }
            catch (Exception ex)
            {
                return new JsonResult(NotFound(ex.Message));
            }

        }    
    }
}
