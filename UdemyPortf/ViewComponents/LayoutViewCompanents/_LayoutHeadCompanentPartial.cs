using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents.LayoutViewCompanents
{
	public class _LayoutHeadCompanentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
