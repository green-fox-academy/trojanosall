using ListingTodosApp.Models;
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
        [HttpGet]
        public IActionResult List()
        {
            return View(TodoRepository.NotDone());
        }


        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title);
            return RedirectToAction("List");
        }


        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            TodoRepository.Delete(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var todo = TodoRepository.Updating(id);
            return View(todo);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            TodoRepository.UpdateTodo(todo);
            return RedirectToAction("List");
        }
    }
}