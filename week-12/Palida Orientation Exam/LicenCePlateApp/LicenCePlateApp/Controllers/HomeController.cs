using LicenCePlateApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicenCePlateApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        LicencePlateRepository LicencePlateRepository;

        public HomeController(LicencePlateRepository licencePlateRepository)
        {
            LicencePlateRepository = licencePlateRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("/search")]
        public IActionResult Search(string userInput)
        {
            return View("Index", LicencePlateRepository.SearchLicencePlateListByUserInput(userInput));
        }
    }
}
