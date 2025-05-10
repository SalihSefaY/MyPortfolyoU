using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;

namespace UdemyPortf.ViewComponents.LayoutViewCompanents
{
	public class _LayoutNavbarCompanentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoListls.Where(x => x.Status == false).Count();
			var values = context.ToDoListls.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}
