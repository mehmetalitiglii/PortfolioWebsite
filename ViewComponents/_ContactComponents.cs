using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class _ContactComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
