using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;

namespace UdemyPortf.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {

        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.features.ToList();
            return View(values);
        }


    }
}
