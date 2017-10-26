using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeOneApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeOneApp.Controllers
{
    public class HomeController : Controller
    {
        Greeting greeting;

        public HomeController(Greeting greeting)
        {
            this.greeting = greeting;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View(greeting);
        }

        //[HttpPost]
        //[Route("index")]
        //public IActionResult Greet()
        //{
        //    greeting.Greet();
        ////    return RedirectToAction("Index");
        //}
    }
}
