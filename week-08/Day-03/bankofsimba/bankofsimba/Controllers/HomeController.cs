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

        [Route("Animals")]
        public IActionResult Animals()
        {
            List<BankAccount> animalsList = new List<BankAccount>();

            var animal1 = new BankAccount("Mufasza", 4000, "Lion", true);
            var animal2 = new BankAccount("Rafiki", 500, "Monkey", true);
            var animal3 = new BankAccount("Zazu", 750, "Parrot", true);
            var animal4 = new BankAccount("Pumbaa", 10000, "Wildpig", true);
            var animal5 = new BankAccount("Timon", 20, "Rat", true);

            animalsList.Add(animal1);
            animalsList.Add(animal2);
            animalsList.Add(animal3);
            animalsList.Add(animal4);
            animalsList.Add(animal5);

            return View(animalsList);
        }
    }
}
