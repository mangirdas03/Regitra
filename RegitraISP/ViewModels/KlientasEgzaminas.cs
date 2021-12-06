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
        public Klienta Klientas { get; set; }
        public List<Filiala> Filialai { get; set; }
    }
}
