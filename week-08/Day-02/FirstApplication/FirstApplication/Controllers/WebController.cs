using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        private static int counter = 0;
        

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Id = ++counter,
                Content = name,
            };

            return View(greeting);
        }
    }
}
