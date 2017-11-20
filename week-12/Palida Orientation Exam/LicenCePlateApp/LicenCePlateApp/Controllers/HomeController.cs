using LicenCePlateApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicenCePlateApp.Controllers
{
    public class HomeController : Controller
    {
        LicencePlateRepository LicencePlateRepository;

        public HomeController(LicencePlateRepository licencePlateRepository)
        {
            LicencePlateRepository = licencePlateRepository;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
