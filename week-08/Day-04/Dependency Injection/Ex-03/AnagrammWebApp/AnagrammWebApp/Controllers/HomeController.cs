using AnagrammWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagrammWebApp.Controllers
{
    public class HomeController : Controller
    {
        AnagramChecker myAnagramchecker;

        public HomeController(AnagramChecker myAnagramchecker)
        {
            this.myAnagramchecker = myAnagramchecker;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Anagram")]
        public IActionResult IsAnagram(string word1, string word2)
        {
            myAnagramchecker.FirstWord = word1;
            myAnagramchecker.SecondWord = word2;

            return RedirectToAction("anagram");
        }

        [HttpGet]
        [Route("Anagram")]
        public IActionResult Anagram()
        {
            return View(myAnagramchecker);
        }
    }
}