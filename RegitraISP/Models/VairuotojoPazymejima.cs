using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class VairuotojoPazymejima
    {
        public int PazymejimoNr { get; set; }
        public DateTime PagaminimoData { get; set; }
        public DateTime GaliojimoData { get; set; }
        public int PazymejimoBukle { get; set; }
        public string FkKlientasasmensKodas { get; set; }

        public virtual Klienta FkKlientasasmensKodasNavigation { get; set; }
        public virtual PazymejimoBukle PazymejimoBukleNavigation { get; set; }
    }
}
