using AnagrammWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagrammWebApp.Controllers
{
    public class HomeController : Controller
    {
        AnagramChecker MyAnagramchecker;

        public HomeController(AnagramChecker myAnagramchecker)
        {
            MyAnagramchecker = myAnagramchecker;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
