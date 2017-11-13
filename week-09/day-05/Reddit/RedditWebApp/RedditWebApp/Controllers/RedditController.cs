using Microsoft.AspNetCore.Mvc;
using RedditWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditWebApp.Controllers
{
    public class RedditController : Controller
    {
        Reddit myReddit;

        public RedditController(Reddit myReddit)
        {
            this.myReddit = myReddit;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
