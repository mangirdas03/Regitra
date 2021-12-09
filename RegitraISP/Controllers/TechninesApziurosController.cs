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
        public TechninesApziurosController(regitraispContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Skaiciuokle()
        {
            return View();
        }
    }
}
