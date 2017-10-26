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
        [Route("")]
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

        [Route("Animals")]
        public IActionResult Animals()
        {
            List<BankAccount> animalsList = new List<BankAccount>
            {
                new BankAccount("Mufasza", 4000, "Lion", true, true),
                new BankAccount("Rafiki", 500, "Monkey", true, true),
                new BankAccount("Zazu", 750, "Parrot", true, true),
                new BankAccount("Pumbaa", 10000, "Wildpig", true, true),
                new BankAccount("Timon", 20, "Rat", true, true)
            };

            return View(animalsList);
        }
    }
}
