using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegitraISP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RegitraISP.Controllers
{
    public class HomeController : Controller
    {
        private readonly regitraispContext _context;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(regitraispContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Miestas.ToList());
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
