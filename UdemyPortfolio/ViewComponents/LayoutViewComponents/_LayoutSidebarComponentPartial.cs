using Microsoft.AspNetCore.Mvc;

namespace UdemyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}

	}
}
