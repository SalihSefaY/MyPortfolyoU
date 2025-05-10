using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
