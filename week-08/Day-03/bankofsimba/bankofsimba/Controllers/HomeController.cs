using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bankofsimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bankofsimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("Simba")]
        public IActionResult Index()
        {
            var BankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"
            };
            return View(BankAccount);
        }
    }
}
