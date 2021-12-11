using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.Models;

namespace RegitraISP.ViewModels
{
    public class AutomobilisApziura
    {
        public List<TechnineApziura> apziuros { get; set; }
        public List<Automobili> automobiliai { get; set; }
        public string Vin { get; set; }
        public string TabelioNr { get; set; }
        public DateTime AtlikimoData { get; set; }
        public DateTime GaliojimoData { get; set; }
        public string DabartineRida { get; set; }
        public float Dumingumas { get; set; }
        public string VaziuoklesBukle { get; set; }
        public string VariklioBukle { get; set; }
        public string KebuloBukle { get; set; }
        public string Pastabos { get; set; }
    }
}
