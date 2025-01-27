using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class _StatsComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
