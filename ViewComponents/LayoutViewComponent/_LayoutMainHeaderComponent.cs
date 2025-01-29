using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents.LayoutViewComponent
{
    public class _LayoutMainHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
