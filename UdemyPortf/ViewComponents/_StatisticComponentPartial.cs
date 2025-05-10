using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents
{
    public class _StatisticComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
