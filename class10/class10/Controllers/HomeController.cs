using System.Diagnostics;
using class10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace class10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("username", "Ume Hani");
            HttpContext.Session.SetInt32("UserId", 12);
            return View();
        }
        public IActionResult About() {
            ViewBag.user = HttpContext.Session.GetString("username");
            ViewBag.userid = HttpContext.Session.GetInt32("UserId");
            ViewBag.email = HttpContext.Session.GetString("email");
            return View();
        }
        public IActionResult Privacy()
        {
            HttpContext.Session.SetString("email", "hanimansoori2004@gmail.com");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
