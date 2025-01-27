using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents
{
    public class _HeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {



            return View();
        }
    }
}