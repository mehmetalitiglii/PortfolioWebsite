using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;
using PortfolioWebsite.DAL.Entities;

namespace PortfolioWebsite.Controllers
{
    public class ToDoListController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var values = context.toDoLists.ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDo(ToDoList toDoList)
        {
            toDoList.IsDone = false;
            context.toDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDo(int id)
        {
            var value = context.toDoLists.Find(id);
            context.toDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDo(int id)
        {
            var value = context.toDoLists.Find(id);

            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateTodo(ToDoList toDoList)
        {
            context.toDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult TaskCompleted(int id)
        {
         var value = context.toDoLists.Find(id);
            value.IsDone = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult TaskNotCompleted(int id)
        {
            var value = context.toDoLists.Find(id);
            value.IsDone = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
