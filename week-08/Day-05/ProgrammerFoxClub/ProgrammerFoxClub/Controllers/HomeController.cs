using Microsoft.AspNetCore.Mvc;
using ProgrammerFoxClub.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProgrammerFoxClub.Controllers
{
    public class HomeController : Controller
    {
        Fox myFox;

        public HomeController(Fox myFox)
        {
            this.myFox = myFox;
        }

        [Route("")]
        public IActionResult Index()
        {
            var myFox = new Fox()
            {
                Name = "Vuk",
                Skills = new List<TrickEnum>(),
                Food = FoodEnum.cake,
                Drink = DrinkEnum.cognac,
            };

            myFox.Skills.Add(TrickEnum.drink);
            myFox.Skills.Add(TrickEnum.love);
            myFox.Skills.Add(TrickEnum.play);

            return View(myFox);
        }

        //[Route("/nutritionStore")]
        //[HttpPost]
        //public IActionResult NutritionStore()
        //{
        //    var myFox = new Fox()
        //    {
        //        Name = "Vuk",
        //        Skills = new List<TrickEnum>(),
        //        Food = FoodEnum.cake,
        //        Drink = DrinkEnum.cognac,
        //    };

        //    myFox.Skills.Add(TrickEnum.drink);
        //    myFox.Skills.Add(TrickEnum.love);
        //    myFox.Skills.Add(TrickEnum.play);

        //    return View(myFox);
    }
}
}
