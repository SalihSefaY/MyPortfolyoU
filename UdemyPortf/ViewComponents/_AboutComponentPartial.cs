﻿using Microsoft.AspNetCore.Mvc;
using UdemyPortf.DALL.Context;

namespace UdemyPortf.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault(); 
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x =>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }


    }
}
