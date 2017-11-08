using FrontendEx.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontendEx.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Append()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil([FromBody] DoUntilClass myDoUntilClass, string what)
        {
            if (what == "factor")
            {
                return Json(new { result = myDoUntilClass.Factor() });
            }

            if (what == "sum")
            {
                return Json(new { result = myDoUntilClass.Sum() });
            }

            if (myDoUntilClass == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (myDoUntilClass.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (string.IsNullOrEmpty(what))
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (what == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }
    }
}
