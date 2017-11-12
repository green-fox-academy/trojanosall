using bankofsimba.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bankofsimba.Controllers
{
    public class HomeController : Controller
    {
        BankAccount MyBankAccount = new BankAccount();

        [Route("")]
        public IActionResult Index()
        {
            var BankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.lion,
            };
            return View(BankAccount);
        }

        [Route("Animals")]
        public IActionResult Animals()
        {
            List<BankAccount> animalsList = new List<BankAccount>
            {
                new BankAccount("Mufasza", 4000, AnimalType.lion, true, true),
                new BankAccount("Rafiki", 500, AnimalType.mandrill, true, true),
                new BankAccount("Zazu", 750, AnimalType.hornbill, true, true),
                new BankAccount("Pumbaa", 10000, AnimalType.warthog, true, true),
                new BankAccount("Timon", 20, AnimalType.merkat, true, true)
            };

            return View(animalsList);
        }

        [HttpPost]
        [Route("Animals")]
        public IActionResult Increase()
        {
            List<BankAccount> animalsList = new List<BankAccount>
            {
                new BankAccount("Mufasza", 4000, AnimalType.lion, true, true),
                new BankAccount("Rafiki", 500, AnimalType.mandrill, true, true),
                new BankAccount("Zazu", 750, AnimalType.hornbill, true, true),
                new BankAccount("Pumbaa", 10000, AnimalType.warthog, true, true),
                new BankAccount("Timon", 20, AnimalType.merkat, true, true)
            };

            foreach (var animal in animalsList)
            {
                animal.Raise();
            }

            return RedirectToAction("Animals");
        }
    }
}
