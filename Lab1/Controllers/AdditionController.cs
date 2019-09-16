using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class AdditionController : Controller
    {

        /**
         * An method to caculate the addition of X and Y
         **/
        public IActionResult Addition(int x, int y)
        {
            
            return Ok("Result = " + (x + y).ToString());

        }

        /**
         * An method to caculate the Multiplication of X and Y
         **/
        public IActionResult Multiplication(int x, int y)
        {
            return Ok("Result = " + (x * y).ToString());
        }
    }
}