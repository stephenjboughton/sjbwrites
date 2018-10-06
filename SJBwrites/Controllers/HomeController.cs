using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SJBwrites.DAL;
using SJBwrites.Models;

namespace SJBwrites.Controllers
{
    public class HomeController : Controller
    {
        private IArticleDAL dal;
        public HomeController(IArticleDAL dal)
        {
            this.dal = dal;
        }

        public IActionResult Index()
        {
            Tuple<List<Review>, List<Preview>, List<Feature>> portfolio = dal.ShowPortfolio();
            return View(portfolio);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
