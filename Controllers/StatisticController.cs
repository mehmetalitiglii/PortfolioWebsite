﻿using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.DAL.Context;

namespace PortfolioWebsite.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext _context = new();
        public IActionResult Index()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Messages.Where(x=>x.IsRead == false).Count();
            ViewBag.v4 = _context.Messages.Where(x=>x.IsRead == true).Count();
            return View();
        }
    }
}
