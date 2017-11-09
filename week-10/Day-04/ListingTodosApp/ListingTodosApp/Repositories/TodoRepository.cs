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

        public void AddTodo(string title)
        {
            var todo = new Todo()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false,
            };

            TodoContext.Todos.Add(todo);
            TodoContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteItem = from deleteOne in TodoContext.Todos
                             where deleteOne.Id == id
                             select deleteOne;

            TodoContext.Todos.Remove(deleteItem.FirstOrDefault());
            TodoContext.SaveChanges();
        }

        public Todo Updating(int id)
        {
            var updateItem = from updateOne in TodoContext.Todos
                             where updateOne.Id == id
                             select updateOne;

            return updateItem.FirstOrDefault();
        }

        public void UpdateTodo(Todo todo)
        {
            TodoContext.Todos.Update(todo);
            TodoContext.SaveChanges();
        }
    }
}

//return TodoContext.Todos.FirstOrDefault(x => x.Id == id);