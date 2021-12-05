using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.Models;

namespace RegitraISP.ViewModels
{
    public class KlientasEgzaminas
    {
        public List<Egzamina> Egzaminai { get; set; }
        public List<Klienta> Klientai { get; set; }
        public List<Filiala> Filialai { get; set; }
    }
}
