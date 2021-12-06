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

        // Registracija i egzaminus
        public IActionResult Registracija()
        {
            // Praleidziamas tik useris.
            if(HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                // Kuriamas Filialu ir Miestu viewmodelis
                KlientasEgzaminas ke = new KlientasEgzaminas();
                ke.Filialai = _context.Filialas.ToList();
                ke.Egzaminai = _context.Egzaminas.ToList();
                ke.Klientas = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
                return View(ke);
            }
            else if(HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 1)
            {
// Alertas darbuotojui?
                return RedirectToAction("EmployeeDashboard", "Home");
            }
            else return RedirectToAction("Login", "Home");

        }

        // Registracija i egzaminus
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
                Klienta temp = _context.Klientas.Find(username);
                if(id == 0)
                {
                    temp.TeorijosEgzData = null;
                    _context.Klientas.Update(temp);
                    _context.SaveChanges();
                }
                else if(id == -1)
                {
                    temp.PraktikosEgzData = null;
                    _context.Klientas.Update(temp);
                    _context.SaveChanges();
                }
                else
                {
                    Egzamina egz = _context.Egzaminas.Find(id);
                    if(egz.EgzaminoTipas == 1)
                    {
                        temp.TeorijosEgzData = egz.Data;
                    }
                    else
                    {
                        temp.PraktikosEgzData = egz.Data;
                    }
                    _context.Klientas.Update(temp);
                    _context.SaveChanges();
                }
                
            }
            catch
            {
                TempData["Error"] = "Galite registruotis tik į vieną egzaminą";
                return View("Registracija");
            }
            //return View("Index");
            Task.Delay(1600).Wait();
            return RedirectToAction("Registracija", "Egzaminavimas");
            //return RedirectToAction("Index");
        }


    }
}
