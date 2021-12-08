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
        private IEnumerable<SelectListItem> cars;
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
        public IActionResult SDK()
        {
            KlientasAutomobilisPasas kap = new KlientasAutomobilisPasas();
            List<Automobili> allCars = _context.Automobilis.ToList();
            List<Automobili> clientCars = new List<Automobili>();
            var userid = HttpContext.Session.GetString("userid");
            foreach (Automobili car in allCars)
            {
                if(car.FkKlientasasmensKodas == userid)
                {
                    clientCars.Add(car);
                }
            }
            kap.Automobiliai = clientCars;
            
            return View(kap);
        }
        [HttpPost]
        public IActionResult SDK(KlientasAutomobilisPasas data)
        {
            var vin = data.Vin;
            Random rand = new Random();
            string sdk = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 9; i++)
            {
                sdk += chars[rand.Next(0, chars.Length)];
            }
            Automobili auto = _context.Automobilis.Find(vin);
            auto.Sdk = sdk;
            _context.Automobilis.Update(auto);
            _context.SaveChanges();
            return RedirectToAction("Index", "AutomobiliuValdymas");
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
        public IActionResult Perleidimas()
        {
            ViewBag.usr = users;
            ViewBag.car = cars;
            return View();
        }

        [HttpPost]
        public IActionResult Perleidimas(KlientasAutomobilisPasas data)
        {
            try
            {
                Automobili auto = _context.Automobilis.Find(data.Vin);
                List<AutomobilioPasa> pasai = _context.AutomobilioPasas.ToList();
                foreach(var pasas in pasai)
                {
                    if(pasas.FkAutomobilisvin == data.Vin)
                    {
                        auto.FkKlientasasmensKodas = data.asmens_kodas;
                        pasas.IsdavimoData = DateTime.Now;
                        var tabelionr = (int)HttpContext.Session.GetInt32("EmployeeID");
                        pasas.FkDarbuotojastabelioNr = tabelionr;
                        _context.Automobilis.Update(auto);
                        _context.AutomobilioPasas.Update(pasas);
                        _context.SaveChanges();
                        break;
                    }
                }
            }

            catch
            {
                return RedirectToAction("Deklaravimas");
            }
            return RedirectToAction("Index", "AutomobiliuValdymas");
        }

        public IActionResult Numeriai()
        {
            ViewBag.car = cars;
            return View();
        }

        [HttpPost]
        public IActionResult Numeriai(Automobili data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Numeriai");
            }
            try
            {
                Automobili auto = _context.Automobilis.Find(data.Vin);
                auto.ValstybiniaiNumeriai = data.ValstybiniaiNumeriai;
                _context.Automobilis.Update(auto);
                _context.SaveChanges();
            }
            catch
            {
                return RedirectToAction("Numeriai");
            }
            return RedirectToAction("Index", "AutomobiliuValdymas");
        }

        public IActionResult Atnaujinimas()
        {
            ViewBag.car = cars;
            return View();
        }

        [HttpPost]
        public IActionResult Atnaujinimas(KlientasAutomobilisPasas data)
        {
            try
            {
                List<AutomobilioPasa> pasai = _context.AutomobilioPasas.ToList();
                foreach (var pasas in pasai)
                {
                    if (pasas.FkAutomobilisvin == data.Vin)
                    {
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

                        _context.AutomobilioPasas.Update(pasas);
                        _context.SaveChanges();
                        break;
                    }
                }
            }

            catch
            {
                return RedirectToAction("Atnaujinimas");
            }
            return RedirectToAction("Index", "AutomobiliuValdymas");
        }
    }
}
