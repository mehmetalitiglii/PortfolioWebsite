using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.ViewComponents;

public class _PortfolioComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
