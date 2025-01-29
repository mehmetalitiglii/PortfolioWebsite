using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents.LayoutViewComponent
{
    public class _LayoutHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
