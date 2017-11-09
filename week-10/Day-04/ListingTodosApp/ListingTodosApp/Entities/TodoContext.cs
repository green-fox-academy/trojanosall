using ListingTodosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ListingTodosApp.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }

    }
}
