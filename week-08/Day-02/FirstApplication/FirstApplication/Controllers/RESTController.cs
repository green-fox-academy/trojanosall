using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {

        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting myGreeting = new Greeting()
            {
                Id = 1,
                Content = "Hello World!"
            };

            return new JsonResult(myGreeting);
        }

        [Route("greetingname")]
        public IActionResult GreetingName(string name)
        {
            Greeting myGreeting = new Greeting()
            {
                Id = 1,
                Content = $"Hello {name}!"
            };

            return new JsonResult(myGreeting);
        }

    }
}
