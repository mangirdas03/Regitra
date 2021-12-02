using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class AutomobilioPasa
    {
        public int PasoNr { get; set; }
        public string AutomobilioSpalva { get; set; }
        public string KuroTipas { get; set; }
        public int Co2Kiekis { get; set; }
        public int Svoris { get; set; }
        public float VariklioLitrazas { get; set; }
        public int KilovatuSkaicius { get; set; }
        public DateTime IsdavimoData { get; set; }
        public string FkAutomobilisvin { get; set; }
        public int FkDarbuotojastabelioNr { get; set; }

        public virtual Automobili FkAutomobilisvinNavigation { get; set; }
        public virtual Darbuotoja FkDarbuotojastabelioNrNavigation { get; set; }
    }
}
