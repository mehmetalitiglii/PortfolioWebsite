using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.ViewComponents
{
    public class _NavbarComponent : ViewComponent
    {
        //PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            //ViewBag.todoListCount = context.toDoLists.Where(x=> x.IsDone == false).Count();
            //var values = context.toDoLists.Where(x=> x.IsDone == false).ToList();

            return View();
        }

    }
}
