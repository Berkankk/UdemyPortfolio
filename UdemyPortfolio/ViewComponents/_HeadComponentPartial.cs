﻿using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
