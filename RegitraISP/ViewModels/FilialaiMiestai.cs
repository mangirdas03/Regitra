using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.Models;

namespace RegitraISP.ViewModels
{
    // Viemodelis skirtas lengvesniam Filialu ir miestu paemimui.
    public class FilialaiMiestai
    {
        public List<Filiala> Filialai { get; set; }
        public List<Miesta> Miestai { get; set; }
        public string Pavadinimas { get; set; }
    }
}
