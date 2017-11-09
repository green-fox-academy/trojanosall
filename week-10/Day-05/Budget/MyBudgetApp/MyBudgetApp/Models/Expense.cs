using System;

namespace MyBudgetApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public ExpenseCategoryEnum Category;
    }
}
