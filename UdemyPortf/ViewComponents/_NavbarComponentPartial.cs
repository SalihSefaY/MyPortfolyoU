﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyPortf.ViewComponents
{
    public class _NavbarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
