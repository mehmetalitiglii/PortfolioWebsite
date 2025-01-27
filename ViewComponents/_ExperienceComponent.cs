using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.ViewComponents
{
    public class _ExperienceComponent:ViewComponent
    {
        PortfolioContext _context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {

            var value = _context.Experiences.ToList();
            return View(value);
        }

    }
}
