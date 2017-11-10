using Microsoft.AspNetCore.Mvc;
using MyBudgetApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyBudgetApp.Controllers
{
    public class MyBudgetController : Controller
    {
        MyBudgetRepository MyBudgetRepository;

        public MyBudgetController(MyBudgetRepository myBudgetRepository)
        {
            MyBudgetRepository = myBudgetRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
