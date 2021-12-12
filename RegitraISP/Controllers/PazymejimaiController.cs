using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using RegitraISP.Models;
using RegitraISP.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.Text;

namespace RegitraISP.Controllers
{
    public class PazymejimaiController : Controller
    {

        private readonly regitraispContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public PazymejimaiController(regitraispContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }


        public IActionResult Index() // VISI
        {
            return View();
        }


        public IActionResult Ikelimas() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                return View();
            }
            else return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult Ikelimas(Nuotrauka model)
        {
            //byte[] foto = Encoding.ASCII.GetBytes(UploadedFile(model));
            string foto = UploadedFile(model);
            Klienta user = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
            user.Nuotrauka = foto;
            _context.Update(user);
            _context.SaveChanges();
            Task.Delay(1600).Wait();
            return RedirectToAction("UserDashboard", "Home");
        }

        private string UploadedFile(Nuotrauka model)
        {
            string uniqueFileName = null;

            if (model.NuotraukaFile != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "profilepics");
                uniqueFileName = HttpContext.Session.GetString("username")+".jpg";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.NuotraukaFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



        public IActionResult DemoPazymejimas() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                Klienta user = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
                return View(user);
            }
            else return RedirectToAction("Login", "Home");
        }



        public IActionResult Bukle() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                VairuotojoPazymejima pazym = _context.VairuotojoPazymejimas.Where(a => a.FkKlientasasmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
                return View(pazym);
            }
            else return RedirectToAction("Login", "Home");
        }



        public IActionResult Uzsakymas() // NAUDOTOJAS
        {
            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                // Paduoda klientą bei pažymėjimų sąrašą į View (Uzsakymas)
                KlientasPazymejimas kp = new KlientasPazymejimas();
                string user = HttpContext.Session.GetString("username");
                kp.Klientas = _context.Klientas.Where(a => a.AsmensKodas.Equals(user)).FirstOrDefault();
                kp.Pazymejimas = _context.VairuotojoPazymejimas.Where(a => a.FkKlientasasmensKodas.Equals(user)).FirstOrDefault();
                return View(kp);
            }
            else return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult UzsakymasProcess()
        {
            try
            {
                // Vartotojas
                string user = HttpContext.Session.GetString("username");

                // Ar išlaikęs teorijos egzaminą
                bool isTheory = _context.Klientas.Where(a => a.AsmensKodas.Equals(user)).FirstOrDefault(a => a.TeorijosEgzIslaikytas).TeorijosEgzIslaikytas;

                // Ar išlaikęs praktikos egzaminą
                bool isPractice = _context.Klientas.Where(a => a.AsmensKodas.Equals(user)).FirstOrDefault(a => a.PraktikosEgzIslaikytas).PraktikosEgzIslaikytas;

                // Jeigu išlaikęs abu egzaminus
                if (isTheory && isPractice)
                {
                    // Užpildo VairuotojoPazymejimas DB lentelę
                    VairuotojoPazymejima vp = new VairuotojoPazymejima();
                    //vp.PazymejimoNr = _context.VairuotojoPazymejimas.OrderBy(a => a.PazymejimoNr).Select(a => a.PazymejimoNr).LastOrDefault() + 1;
                    vp.PagaminimoData = DateTime.Today.AddDays(10); // Pagamina per 10 dienų
                    vp.GaliojimoData = DateTime.Today.AddYears(2); // Galioja 2 metus
                    vp.PazymejimoBukle = 1;
                    vp.FkKlientasasmensKodas = _context.Klientas.Where(a => a.AsmensKodas.Equals(user)).FirstOrDefault().AsmensKodas;

                    // Įrašo duomenis į duomenų bazę
                    _context.VairuotojoPazymejimas.Add(vp);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("Uzsakymas");
            }
            Task.Delay(1600).Wait();
            return RedirectToAction("Bukle", "Pazymejimai");
        }



        public IActionResult Atnaujinimas() // NAUDOTOJAS
        {

            if (HttpContext.Session.GetString("username") != null && HttpContext.Session.GetInt32("isEmployee") == 0)
            {
                // Paduoda klientą bei pažymėjimų sąrašą į View (Atnaujinimas)
                KlientasPazymejimas kp = new KlientasPazymejimas();
                string user = HttpContext.Session.GetString("username");
                kp.Klientas = _context.Klientas.Where(a => a.AsmensKodas.Equals(user)).FirstOrDefault();
                kp.Pazymejimas = _context.VairuotojoPazymejimas.Where(a => a.FkKlientasasmensKodas.Equals(user)).FirstOrDefault();
                return View(kp);
            }
            else return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult AtnaujinimasProcess()
        {
            // Vartotojas
            string user = HttpContext.Session.GetString("username");

            // Atnaujina galiojimo datą VairuotojoPazymejimas DB lentelėje
            VairuotojoPazymejima vp = new VairuotojoPazymejima();
            vp = _context.VairuotojoPazymejimas.Where(a => a.FkKlientasasmensKodas.Equals(user)).FirstOrDefault();
            vp.GaliojimoData = DateTime.Today.AddYears(10); // Pratęsia galiojima 10 metų

            // Įrašo duomenis į duomenų bazę
            _context.VairuotojoPazymejimas.Update(vp);
            _context.SaveChanges();
            Task.Delay(1600).Wait();
            return RedirectToAction("Bukle", "Pazymejimai");
        }

    }
}
