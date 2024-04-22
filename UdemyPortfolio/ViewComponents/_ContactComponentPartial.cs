using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
