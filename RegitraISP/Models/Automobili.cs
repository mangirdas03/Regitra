using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Automobili
    {
        public Automobili()
        {
            AutomobilioPasas = new HashSet<AutomobilioPasa>();
            TechnineApziuras = new HashSet<TechnineApziura>();
        }

        public string Vin { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public string Sdk { get; set; }
        public DateTime PagaminimoMetai { get; set; }
        public string PaskutineRegSalis { get; set; }
        public string PirmojiRegSalis { get; set; }
        public string ValstybiniaiNumeriai { get; set; }
        public string FkKlientasasmensKodas { get; set; }

        public virtual Klienta FkKlientasasmensKodasNavigation { get; set; }
        public virtual ICollection<AutomobilioPasa> AutomobilioPasas { get; set; }
        public virtual ICollection<TechnineApziura> TechnineApziuras { get; set; }
    }
}
