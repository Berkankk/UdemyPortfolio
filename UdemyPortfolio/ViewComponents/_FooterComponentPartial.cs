using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
