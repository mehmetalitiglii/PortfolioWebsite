using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.ViewComponents;

public class _AboutComponents: ViewComponent
{
    PortfolioContext context = new();

    public IViewComponentResult Invoke()
    {
        ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
        ViewBag.aboutSubDescription = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
        ViewBag.aboutDetail = context.Abouts.Select(x => x.Details).FirstOrDefault();
        return View();
    }

}
