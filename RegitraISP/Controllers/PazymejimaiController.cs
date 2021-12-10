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


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Ikelimas()
        {
            return View();
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



        public IActionResult DemoPazymejimas()
        {
            Klienta user = _context.Klientas.Where(a => a.AsmensKodas.Equals(HttpContext.Session.GetString("username"))).FirstOrDefault();
            return View(user);
        }




    }
}
