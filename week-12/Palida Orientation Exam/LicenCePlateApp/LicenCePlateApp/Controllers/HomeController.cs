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

        [HttpGet]
        [Route("/search/police")]
        public IActionResult SearchForPoliceCars()
        {
            return View("Index", LicencePlateRepository.SearchPoliceCarList());
        }

        [HttpGet]
        [Route("/search/diplomats")]
        public IActionResult SearchForDiplomatsCars()
        {
            return View("Index", LicencePlateRepository.SearchDiplomatsCarList());
        }

        //[HttpGet]
        //[Route("/search/{brand}")]
        //public IActionResult RefineSearchingByBrand(string brand)
        //{
        //    return View("Index", LicencePlateRepository.RefineTheOriginalSearchingBasedOnBrand(brand));
        //}

        [HttpGet]
        [Route("/{brand}")]
        public IActionResult SearchingByBrand(string brand)
        {
            return View("Index", LicencePlateRepository.RefineTheOriginalSearchingBasedOnBrand(brand));
        }
    }
}
