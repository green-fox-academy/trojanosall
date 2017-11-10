using MyBudgetApp.Entities;
using MyBudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBudgetApp.Repositories
{
    public class MyBudgetRepository
    {
        MyBudgetContext MyBudgetContext;

        public MyBudgetRepository(MyBudgetContext myBudgetContext)
        {
            MyBudgetContext = myBudgetContext;
        }

        public List<Expense> GetList()
        {
            return MyBudgetContext.Expenses.ToList();
        }

        public void AddExpense(string title, DateTime date, ExpenseCategoryEnum category)
        {
            var expense = new Expense()
            {
                Title = title,
                Date = date,
                Category = category,
            };

            MyBudgetContext.Expenses.Add(expense);
            MyBudgetContext.SaveChanges();
        }
    }
}
