using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.ViewModels;
using RegitraISP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace RegitraISP.Controllers
{
    public class TechninesApziurosController : Controller
    {
        private readonly regitraispContext _context;
        private IEnumerable<SelectListItem> cars;
        public TechninesApziurosController(regitraispContext context)
        {
            _context = context;
            cars = _context.Automobilis.Select(d =>
              new SelectListItem
              {
                  Value = d.Vin.ToString(),
                  Text = string.Format("{0} {1}, {2}", d.Marke, d.Modelis, d.Vin)
              });
        }
        public IActionResult Index() // VISI
        {
            return View();
        }


        public IActionResult Skaiciuokle() // VISI
        {
            return View();
        }


        public IActionResult Deklaravimas() // DARBUOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 1)
            {
                ViewBag.car = cars;
                return View();
            }
            else return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult Deklaravimas(AutomobilisApziura aa)
        {
            try
            {
                TechnineApziura ta = new TechnineApziura();
                ta.AtlikimoData = DateTime.Now;
                ta.GaliojimoData = DateTime.Now.AddYears(2);
                ta.DabartineRida = aa.DabartineRida;
                ta.Dumingumas = aa.Dumingumas;
                ta.VaziuoklesBukle = aa.VaziuoklesBukle;
                ta.VariklioBukle = aa.VariklioBukle;
                ta.KebuloBukle = aa.KebuloBukle;
                ta.Pastabos = aa.Pastabos;
                ta.FkAutomobilisvin = aa.Vin;
                ta.FkDarbuotojastabelioNr = (int)HttpContext.Session.GetInt32("EmployeeID");

                _context.TechnineApziuras.Add(ta);
                _context.SaveChanges();
            }
            catch
            {
                return RedirectToAction("Deklaravimas");
            }
            return RedirectToAction("Index", "TechninesApziuros");
        }



        public IActionResult Istorija() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                AutomobilisApziura aa = new AutomobilisApziura();
                aa.apziuros = _context.TechnineApziuras.ToList();
                aa.automobiliai = _context.Automobilis.ToList();
                return View(aa);
            }
            else return RedirectToAction("Login", "Home");
        }




        public IActionResult Leidimas() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                // Paduoda kliento automobilių sąrašą į View (Leidimas)
                AutomobilisTechnine at = new AutomobilisTechnine();
                string user = HttpContext.Session.GetString("username");
                at.Automobiliai = _context.Automobilis.Where(a => a.FkKlientasasmensKodas.Equals(user)).ToList();
                at.Apziuros = _context.TechnineApziuras.ToList();
                return View(at);
            }
            else return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult Leidimas(AutomobilisTechnine data)
        {
            TechnineApziura ta = new TechnineApziura();

            ta = _context.TechnineApziuras.OrderBy(a => a.ApziurosId).Where(a => a.FkAutomobilisvin.Equals(data.Vin)).LastOrDefault();

            ta.GaliojimoData = DateTime.Today;//.AddDays(1); // Pratęsia viena diena

            _context.TechnineApziuras.Update(ta);
            _context.SaveChanges();
            Task.Delay(1600).Wait();
            return RedirectToAction("Leidimas", "TechninesApziuros");
        }
    }
}
