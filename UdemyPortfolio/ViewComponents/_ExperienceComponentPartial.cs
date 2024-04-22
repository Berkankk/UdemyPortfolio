using Microsoft.AspNetCore.Mvc;
using UdemyPortfolio.DAL.Context;

namespace UdemyPortfolio.ViewComponents
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
