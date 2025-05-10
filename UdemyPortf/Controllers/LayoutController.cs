using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
