using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
