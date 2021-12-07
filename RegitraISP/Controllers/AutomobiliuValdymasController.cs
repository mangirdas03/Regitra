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

    public class AutomobiliuValdymasController : Controller
    {
        private IEnumerable<SelectListItem> users;
        private readonly regitraispContext _context;
        public AutomobiliuValdymasController(regitraispContext context)
        {
            _context = context;
            users = _context.Klientas.Select(d =>
              new SelectListItem
              {
                  Value = d.AsmensKodas.ToString(),
                  Text = string.Format("{0} {1}, {2}", d.Vardas, d.Pavarde, d.AsmensKodas)
              }) ;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Deklaravimas()
        {
            ViewBag.kap = users;
            return View();
        }

        [HttpPost]
        public IActionResult Deklaravimas(KlientasAutomobilisPasas data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Deklaravimas");
            }
            try
            {
                Automobili auto = new Automobili();

                auto.Vin = data.Vin;
                auto.Marke = data.Marke;
                auto.Modelis = data.Modelis;
                auto.PagaminimoMetai = data.PagaminimoMetai;
                auto.PaskutineRegSalis = data.PaskutineRegSalis;
                auto.PirmojiRegSalis = data.PirmojiRegSalis;
                auto.ValstybiniaiNumeriai = data.ValstybiniaiNumeriai;
                auto.FkKlientasasmensKodas = data.asmens_kodas;
                AutomobilioPasa pasas = new AutomobilioPasa();
                pasas.AutomobilioSpalva = data.AutomobilioSpalva;
                pasas.KuroTipas = data.KuroTipas;
                pasas.Co2Kiekis = data.Co2Kiekis;
                pasas.Svoris = data.Svoris;
                pasas.VariklioLitrazas = data.VariklioLitrazas;
                pasas.KilovatuSkaicius = data.KilovatuSkaicius;
                pasas.IsdavimoData = DateTime.Now;
                pasas.FkAutomobilisvin = data.Vin;
                var tabelionr = (int)HttpContext.Session.GetInt32("EmployeeID");
                pasas.FkDarbuotojastabelioNr = tabelionr;

                _context.Automobilis.Add(auto);
                _context.AutomobilioPasas.Add(pasas);
                _context.SaveChanges();

            }

            catch
            {
                return RedirectToAction("Deklaravimas");
            }
            return RedirectToAction("Index", "AutomobiliuValdymas");
        }
    }
}
