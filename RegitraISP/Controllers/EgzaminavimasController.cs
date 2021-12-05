using Microsoft.AspNetCore.Mvc;
using RegitraISP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.ViewModels;
using Microsoft.AspNetCore.Http;

namespace RegitraISP.Controllers
{

    public class EgzaminavimasController : Controller
    {
        private readonly regitraispContext _context;

        public EgzaminavimasController(regitraispContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Filialai()
        {
            // Kuriamas Filialu ir Miestu viewmodelis
            FilialaiMiestai fm = new FilialaiMiestai();
            fm.Filialai = _context.Filialas.ToList();
            fm.Miestai = _context.Miestas.ToList();
            return View(fm);
        }

        public IActionResult Registracija()
        {
            // Kuriamas Filialu ir Miestu viewmodelis
            KlientasEgzaminas ke = new KlientasEgzaminas();
            ke.Filialai = _context.Filialas.ToList();
            ke.Egzaminai = _context.Egzaminas.ToList();
            ke.Klientai = _context.Klientas.ToList();
            return View(ke);
        }

        [HttpPost]
        public IActionResult Registracija(IFormCollection data)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string username = data["name"].ToString();
                string date = data["egz"].ToString();
                int id = int.Parse(date);
                Egzamina egz = _context.Egzaminas.Find(id);
                Klienta temp = _context.Klientas.Find(username);
                temp.TeorijosEgzData = egz.Data;
                _context.Klientas.Add(temp);
                _context.SaveChanges();
            }
            catch
            {
                TempData["Error"] = "Galite registruotis tik į vieną egzaminą";
                return View("Registracija");
            }
            string x = data["egz"].ToString();
            return View();
        }


    }
}
