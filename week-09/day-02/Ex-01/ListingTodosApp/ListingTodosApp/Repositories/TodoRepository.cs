using ListingTodosApp.Entities;
using ListingTodosApp.Models;
using System.Collections.Generic;
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

        public List<Todo> GetList()
        {
            return TodoContext.Todos.ToList();
        }

        public List<Todo> NotDone()
        {
            var notDone = from notReady in TodoContext.Todos
                          where notReady.IsDone == false
                          select notReady;

            return notDone.ToList();
        }
    }
}
