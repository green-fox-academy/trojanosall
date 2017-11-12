using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return Content("Hello");
        }

        [Route("Hello")]
        public IActionResult Hello()
        {
            return Content("Helloka Word!!!!");
        }
    }
}
