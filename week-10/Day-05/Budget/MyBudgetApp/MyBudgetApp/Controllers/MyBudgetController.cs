using Microsoft.AspNetCore.Mvc;
using MyBudgetApp.Models;
using MyBudgetApp.Repositories;
using System;

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

        [Route("")]
        [HttpGet]
        public IActionResult List()
        {
            return View(MyBudgetRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string title, DateTime date, ExpenseCategoryEnum category, int amount)
        {
            MyBudgetRepository.AddExpense(title, date, category, amount);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            MyBudgetRepository.Delete(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var expense = MyBudgetRepository.Updating(id);
            return View(expense);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Expense expense)
        {
            MyBudgetRepository.UpdateExpense(expense);
            return RedirectToAction("List");
        }
    }
}
