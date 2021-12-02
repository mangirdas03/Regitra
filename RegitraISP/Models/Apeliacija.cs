using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Apeliacija
    {
        public string Priezastis { get; set; }
        public string Tekstas { get; set; }
        public int IdApeliacija { get; set; }
        public string FkKlientasasmensKodas { get; set; }

        public virtual Klienta FkKlientasasmensKodasNavigation { get; set; }
    }
}
