using Microsoft.AspNetCore.Mvc;
using UdemyPortfolio.DAL.Context;

namespace UdemyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList(); 
            return View(values);
        }
    }
}
