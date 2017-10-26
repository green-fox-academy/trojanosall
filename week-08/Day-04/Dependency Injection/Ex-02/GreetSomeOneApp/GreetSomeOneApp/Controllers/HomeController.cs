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
        UserInfo userInfo;

        public HomeController(UserInfo userInfo)
        {
            this.userInfo = userInfo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(userInfo);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(string Name)
        {
            userInfo.Name = Name;
            return RedirectToAction("Greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return View(userInfo);
        }
    }
}
