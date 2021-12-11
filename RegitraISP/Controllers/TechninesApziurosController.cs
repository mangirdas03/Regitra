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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Skaiciuokle()
        {
            return View();
        }
        public IActionResult Deklaravimas()
        {
            ViewBag.car = cars;
            return View();
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

        public IActionResult Istorija()
        {
            AutomobilisApziura aa = new AutomobilisApziura();
            aa.apziuros = _context.TechnineApziuras.ToList();
            aa.automobiliai = _context.Automobilis.ToList();
            return View(aa);
        }
    }
}
