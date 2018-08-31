using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        private Queue<Cocktail> orders;
        private List<Cocktail> cocktailMenu;
        public HomeController()
        {
            cocktailMenu = new List<Cocktail>
            {
                new Cocktail()
                { Name = "cocktail", Cost = "10.00" },
                new Cocktail()
                { Name = "cocktail1", Cost = "11.70" },
                new Cocktail()
                { Name = "cocktail2", Cost = "12.50" },
                new Cocktail()
                { Name = "cocktail3", Cost = "13.10" },
                new Cocktail()
                { Name = "cocktail4", Cost = "14.80" },
                new Cocktail()
                { Name = "cocktail5", Cost = "15.70" },
                new Cocktail()
                { Name = "cocktail6", Cost = "16.60" },
                new Cocktail()
                { Name = "cocktail7", Cost = "17.30" },
                new Cocktail()
                { Name = "cocktail8", Cost = "18.00" },
                new Cocktail()
                { Name = "cocktail9", Cost = "19.20" }
            };

        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View(cocktailMenu);
        }
        public ActionResult OrderQueue()
        {
            return View(orders);
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
