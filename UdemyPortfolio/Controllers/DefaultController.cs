using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
