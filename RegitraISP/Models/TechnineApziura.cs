using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class TechnineApziura
    {
        public int ApziurosId { get; set; }
        public DateTime AtlikimoData { get; set; }
        public DateTime GaliojimoData { get; set; }
        public string DabartineRida { get; set; }
        public float Dumingumas { get; set; }
        public string VaziuoklesBukle { get; set; }
        public string VariklioBukle { get; set; }
        public string KebuloBukle { get; set; }
        public string Pastabos { get; set; }
        public int FkDarbuotojastabelioNr { get; set; }
        public string FkAutomobilisvin { get; set; }

        public virtual Automobili FkAutomobilisvinNavigation { get; set; }
        public virtual Darbuotoja FkDarbuotojastabelioNrNavigation { get; set; }
    }
}
