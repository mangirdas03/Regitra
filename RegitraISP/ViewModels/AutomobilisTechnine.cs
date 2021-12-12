using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.Models;

namespace RegitraISP.ViewModels
{
    public class AutomobilisTechnine
    {
        public List<Automobili> Automobiliai { get; set; }
        public List<TechnineApziura> Apziuros { get; set; }
        public string Vin { get; set; }
    }
}
