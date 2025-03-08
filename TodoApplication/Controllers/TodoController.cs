using Microsoft.AspNetCore.Mvc;
using TodoApplication.Models;
using TodoApplication.Services;

namespace TodoApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _toDoService;

        public TodoController(ITodoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult Index()
        {
            var items = _toDoService.GetAll();
            return View(items);
        }

        public IActionResult Create()
        {
            var newItem = new TodoItem();
            return View(newItem);
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                _toDoService.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = _toDoService.GetById(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                _toDoService.Update(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = _toDoService.GetById(id);
            if (item == null) return NotFound();

            _toDoService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
