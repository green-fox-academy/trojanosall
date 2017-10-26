using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        CounterClass counter;

        public HomeController(CounterClass counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route("index")]
        public IActionResult Increase()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}
