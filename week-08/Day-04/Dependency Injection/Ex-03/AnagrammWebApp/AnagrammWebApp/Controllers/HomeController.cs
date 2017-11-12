using AnagrammWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagrammWebApp.Controllers
{
    public class HomeController : Controller
    {
        AnagramChecker myAnagramchecker;

        public HomeController(AnagramChecker myAnagramchecker)
        {
            this.myAnagramchecker = myAnagramchecker;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(/*myAnagramchecker*/);
        }
    }
}
