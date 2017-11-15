// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using GreenFoxQuizAPI.Models;
using GreenFoxQuizAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            var quizList = quizRepository.GetRandomListOfQuiz();
            var questionList = (from quiz in quizList orderby quiz.Id select new { quiz.Id, quiz.Question }).ToList();

            return Json(questionList);
        }

        [HttpPost]
        [Route("/answers")]
        public IActionResult Answers([FromQuery] QuizQuestion quizQuestions)
        {
            quizRepository.GetAnswerForRandomQuestion(quizQuestions);
            return Json(quizQuestions);
        }
    }
}
