using Microsoft.EntityFrameworkCore;
using MyBudgetApp.Models;

namespace MyBudgetApp.Entities
{
    public class MyBudgetContext : DbContext
    {
        public MyBudgetContext(DbContextOptions<MyBudgetContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
