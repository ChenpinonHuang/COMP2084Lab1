using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class AdditionController : Controller
    {

        public IActionResult Addition(int x, int y)
        {
            
            return Ok("Result = " + (x + y).ToString());

        }

       
    }
}