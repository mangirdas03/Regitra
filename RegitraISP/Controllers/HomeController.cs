using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegitraISP.Models;
using RegitraISP.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

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
                var checkUser = _context.Klientas.Where(a => a.AsmensKodas.Equals(user.Name)).FirstOrDefault();
                var checkEmpolyee = _context.Darbuotojas.Where(b => b.TabelioNr.ToString().Equals(user.Name)).FirstOrDefault();

                if (checkUser != null && BCryptNet.Verify(user.Password, checkUser.Slaptazodis))
                {
                    HttpContext.Session.SetString("username", user.Name.ToString());
                    //HttpContext.Session.SetString("passw", user.Password.ToString()); // Illegal?
                    HttpContext.Session.SetInt32("isEmployee", 0);
                    HttpContext.Session.SetString("userid", checkUser.AsmensKodas);
                    return RedirectToAction("UserDashboard");
                }
                else if(checkEmpolyee != null && BCryptNet.Verify(user.Password, checkEmpolyee.Slaptazodis))
                {
                    HttpContext.Session.SetString("username", user.Name.ToString());
                    //HttpContext.Session.SetString("passw", user.Password.ToString()); // Illegal?
                    HttpContext.Session.SetInt32("isEmployee", 1);
                    HttpContext.Session.SetInt32("EmployeeID", checkEmpolyee.TabelioNr);
                    return RedirectToAction("EmployeeDashboard");
                }
            }
            return View();
        }

        public ActionResult EmployeeDashboard()
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 1)
            {
                var loggedUser = _context.Darbuotojas.Where(a => a.TabelioNr.ToString().Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
                return View(loggedUser);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult UserDashboard()
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                var loggedUser = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
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


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterKlientas user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {   // sutvarko checkboxus -_-
                if (user.PraktikosEgzIslaikytas != true)
                {
                    user.PraktikosEgzIslaikytas = false;
                    user.PraktikosEgzData = null;
                }
                if (user.TeorijosEgzIslaikytas != true)
                {
                    user.TeorijosEgzIslaikytas = false;
                    user.TeorijosEgzData = null;
                }

                user.Slaptazodis = BCryptNet.HashPassword(user.Slaptazodis);
                // Mapping?
                Klienta newUser = new Klienta();
                newUser.AsmensKodas = user.AsmensKodas;
                newUser.Slaptazodis = user.Slaptazodis;
                newUser.Vardas = user.Vardas;
                newUser.Pavarde = user.Pavarde;
                newUser.TelNr = user.TelNr;
                newUser.ElPastas = user.ElPastas;
                newUser.PraktikosEgzIslaikytas = user.PraktikosEgzIslaikytas;
                newUser.PraktikosEgzData = user.PraktikosEgzData;
                newUser.TeorijosEgzIslaikytas = user.TeorijosEgzIslaikytas;
                newUser.TeorijosEgzData = user.TeorijosEgzData;

                _context.Klientas.Add(newUser);
                _context.SaveChanges();
            }
            catch
            {
                TempData["Error"] = "Toks naudotojas jau registruotas!";
                return View("Register");
            }
            return RedirectToAction("Login");
        }


    }
}
