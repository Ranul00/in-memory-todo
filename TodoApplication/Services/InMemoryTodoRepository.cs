using TodoApplication.Services;
using TodoApplication.Models;

namespace TodoApplication.Services
{
    public class TodoService : ITodoService
    {

        private readonly List<TodoItem> _todoList = new();
        private int _nextId = 1;

        public List<TodoItem> GetAll()
        {
            return _todoList.OrderByDescending(t => t.CreatedDate).ToList(); // return the list newest 1st
        }
        public TodoItem GetById(int id)
        {
            return _todoList.FirstOrDefault(t => t.Id == id);
        }

        public void Add(TodoItem item)
        {
            item.Id = _todoList.Count > 0 ? _todoList.Max(t => t.Id) + 1 : 1;
            item.CreatedDate = DateTime.Now;
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var existingItem = GetById(item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.IsCompleted = item.IsCompleted;
            }
        }

        public void Delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _todoList.Remove(item);
            }
        }
    }
}
