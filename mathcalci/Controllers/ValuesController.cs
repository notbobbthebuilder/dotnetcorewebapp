using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mathcalci.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet("Add")]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        [HttpGet("Subtract")]
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
        [HttpGet("Multiply")]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        [HttpGet("Divide")]
        public float Divide(float value1, float value2)
        {
            return value1 / value2;
        }
    }
}
