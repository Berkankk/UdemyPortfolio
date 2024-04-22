using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
