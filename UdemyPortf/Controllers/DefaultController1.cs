using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
