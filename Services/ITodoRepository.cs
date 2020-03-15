using System.Collections.Generic;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAllTodoItems();
    }
}