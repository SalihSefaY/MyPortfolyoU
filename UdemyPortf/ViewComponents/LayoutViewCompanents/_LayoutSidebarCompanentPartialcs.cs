using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents.LayoutViewCompanents
{
	public class _LayoutSidebarCompanentPartialcs : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
