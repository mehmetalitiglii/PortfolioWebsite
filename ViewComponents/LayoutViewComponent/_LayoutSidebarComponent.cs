using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents.LayoutViewComponent
{
    public class _LayoutSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
