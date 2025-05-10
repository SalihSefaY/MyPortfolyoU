using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents.LayoutViewCompanents
{
	public class _LayoutScriptCompanentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
