using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
