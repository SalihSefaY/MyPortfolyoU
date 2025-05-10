using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;
using UdemyPortf.DALL.entities;

namespace UdemyPortf.Controllers
{
	public class ToDoListController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = context.ToDoListls.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateToDoList()
		{
				return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList toDoList)
		{
			toDoList.Status = false;
			context.ToDoListls.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var value = context.ToDoListls.Find(id);
			context.ToDoListls.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = context.ToDoListls.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult Update(ToDoList toDoList)
		{
			context.ToDoListls.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		
		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var value = context.ToDoListls.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var value = context.ToDoListls.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}	
}
