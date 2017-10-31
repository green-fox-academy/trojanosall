using ListingTodosApp.Entities;
using ListingTodosApp.Models;
using System.Linq;

namespace ListingTodosApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void AddTodo()
        {
            var todo = new Todo()
            {                
                Title = "Practice a lot",
                IsUrgent = true,
                IsDone = false,
            };

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public Todo GetLastToDo()
        {
            return TodoContext.Todos.Last();
        }
    }
}
