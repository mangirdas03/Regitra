using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Darbuotoja
    {
        public Darbuotoja()
        {
            AutomobilioPasas = new HashSet<AutomobilioPasa>();
            TechnineApziuras = new HashSet<TechnineApziura>();
        }

        public int TabelioNr { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int FkFilialasidFilialas { get; set; }

        public virtual Filiala FkFilialasidFilialasNavigation { get; set; }
        public virtual ICollection<AutomobilioPasa> AutomobilioPasas { get; set; }
        public virtual ICollection<TechnineApziura> TechnineApziuras { get; set; }
    }
}
