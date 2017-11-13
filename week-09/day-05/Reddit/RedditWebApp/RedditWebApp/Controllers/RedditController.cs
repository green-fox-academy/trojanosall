using Microsoft.AspNetCore.Mvc;
using RedditWebApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditWebApp.Controllers
{
    public class RedditController : Controller
    {
        RedditRepository redditRepository;

        public RedditController(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
