using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.ViewComponents
{
    public class _SkillComponent: ViewComponent
    {
        PortfolioContext Context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = Context.Skills.ToList();
            return View(value);
        }

    }
}
