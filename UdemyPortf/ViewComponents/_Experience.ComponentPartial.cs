using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;

namespace UdemyPortf.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
