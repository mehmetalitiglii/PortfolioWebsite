using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class _LayoutScriptComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
