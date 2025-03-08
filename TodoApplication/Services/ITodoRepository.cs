using TodoApplication.Models;

namespace TodoApplication.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetAll();
        TodoItem GetById(int id);
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(int id);
    }
}
