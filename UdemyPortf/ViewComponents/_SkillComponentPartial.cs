using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;

namespace UdemyPortf.ViewComponents
{
    public class _SkillComponentPartial: ViewComponent
    {

        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();

            return View(values);
        }
    }
}
