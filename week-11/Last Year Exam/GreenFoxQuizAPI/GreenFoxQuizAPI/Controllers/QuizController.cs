// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using GreenFoxQuizAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxQuizAPI.Controllers
{
    public class QuizController : Controller
    {
        QuizRepository quizRepository;

        public QuizController(QuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        [HttpGet]
        [Route("/questions")]
        public IActionResult Questions()
        {
            return View(quizRepository.GetRandomQuestions());
        }
    }
}
