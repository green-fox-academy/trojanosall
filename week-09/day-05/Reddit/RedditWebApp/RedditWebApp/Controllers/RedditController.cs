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

        [HttpGet]
        [Route("")]
        [Route("/post")]
        public IActionResult Post()
        {
            return View(redditRepository.GetList());
        }

        [Route("/vote/up/{id}")]
        //[HttpPost]
        public IActionResult UpVote(int id)
        {
            redditRepository.Vote("up", id);
            return RedirectToAction("Post");
        }

        [Route("/vote/down/{id}")]
        //[HttpPost]
        public IActionResult DownVote(int id)
        {
            redditRepository.Vote("down", id);
            return RedirectToAction("Post");
        }

    }
}
