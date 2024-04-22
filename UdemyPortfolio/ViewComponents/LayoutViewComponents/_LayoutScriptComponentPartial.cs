using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
