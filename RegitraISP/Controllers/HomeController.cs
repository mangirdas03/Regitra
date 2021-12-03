using Microsoft.AspNetCore.Http;
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
            return View(_context.Darbuotojas.ToList());
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



        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UnauthUser user)
        {
            if (ModelState.IsValid)
            {
                var checkUser = _context.Klientas.Where(a => a.AsmensKodas.Equals(user.Name) && a.Slaptazodis.Equals(user.Password)).FirstOrDefault();
                var checkEmpolyee = _context.Darbuotojas.Where(b => b.TabelioNr.ToString().Equals(user.Name) && b.Slaptazodis.Equals(user.Password)).FirstOrDefault();
                if (checkUser != null)
                {
                    HttpContext.Session.SetString("username", user.Name.ToString());
                    HttpContext.Session.SetString("passw", user.Password.ToString());
                    HttpContext.Session.SetInt32("isEmployee", 0);

                    return RedirectToAction("UserDashboard");
                }
                else if(checkEmpolyee != null)
                {
                    HttpContext.Session.SetString("username", user.Name.ToString());
                    HttpContext.Session.SetString("passw", user.Password.ToString());
                    HttpContext.Session.SetInt32("isEmployee", 1);

                    return RedirectToAction("EmployeeDashboard");
                }
            }
            return View();
        }

        public ActionResult EmployeeDashboard()
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 1)
            {
                var loggedUser = _context.Darbuotojas.Where(a => a.TabelioNr.Equals(HttpContext.Session.GetString("username")) && a.Slaptazodis.Equals(HttpContext.Session.GetString("passw"))).FirstOrDefault();
                return View(loggedUser);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult UserDashboard()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                var loggedUser = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username")) && a.Slaptazodis.Equals(HttpContext.Session.GetString("passw"))).FirstOrDefault();
                return View(loggedUser);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        // ISVALO VISA SESIJA, ATEITY GALI BUT BEDU NAUDOJANT SESIJAS
        public ActionResult Logout()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                HttpContext.Session.Clear();
            }
            return RedirectToAction("Login");
        }

        //throw new Exception("test");

    }
}
