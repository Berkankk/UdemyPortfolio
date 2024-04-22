using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
