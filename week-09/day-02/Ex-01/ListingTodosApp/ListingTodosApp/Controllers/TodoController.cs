using ListingTodosApp.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodosApp.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("")]
        public IActionResult List()
        {
            return View(TodoRepository.GetLastToDo());
        }

        [Route("/add")]
        public IActionResult AddTodo()
        {
            TodoRepository.AddTodo();
            return RedirectToAction("List");
        }
    }
}
