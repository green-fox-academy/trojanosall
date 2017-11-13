using Microsoft.AspNetCore.Mvc;
using RedditWebApp.Models;
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
        [Route("/post")]
        public IActionResult Post()
        {
            return View(redditRepository.GetList());
        }

        [Route("/{id}/upvote")]
        [HttpPost]
        public IActionResult Upvote(Reddit reddit)
        {
            redditRepository.UpVoteReddit(reddit);
            return RedirectToAction("Post");
        }

    }
}
