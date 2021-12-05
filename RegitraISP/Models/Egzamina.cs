using System;
using System.Collections.Generic;


#nullable disable

namespace RegitraISP.Models
{
    public partial class Egzamina
    {
        public DateTime Data { get; set; }
        public int EgzaminoTipas { get; set; }
        public int IdEgzaminas { get; set; }
        public string FkKlientasasmensKodas { get; set; }
        public int FkFilialasidFilialas { get; set; }

        public virtual EgzaminoTipa EgzaminoTipasNavigation { get; set; }
        public virtual Filiala FkFilialasidFilialasNavigation { get; set; }
        public virtual Klienta FkKlientasasmensKodasNavigation { get; set; }
    }
}
