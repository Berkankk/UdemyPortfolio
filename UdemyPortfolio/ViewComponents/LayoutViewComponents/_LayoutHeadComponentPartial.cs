using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
 

