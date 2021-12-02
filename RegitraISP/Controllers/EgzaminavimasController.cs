using Microsoft.AspNetCore.Mvc;
using RegitraISP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.ViewModels;

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




    }
}
