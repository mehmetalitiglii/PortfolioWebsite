using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.ViewComponents
{
    public class _FeatureComponent: ViewComponent
    {
        PortfolioContext _context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();

            return View(values);
        }

    }
}