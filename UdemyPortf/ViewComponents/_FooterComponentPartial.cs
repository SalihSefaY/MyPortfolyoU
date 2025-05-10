using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
