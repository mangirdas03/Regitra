using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Klienta
    {
        public Klienta()
        {
            Apeliacijas = new HashSet<Apeliacija>();
            Automobilis = new HashSet<Automobili>();
            Egzaminas = new HashSet<Egzamina>();
            VairuotojoPazymejimas = new HashSet<VairuotojoPazymejima>();
        }

        public string AsmensKodas { get; set; }
        public string Slaptazodis { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string TelNr { get; set; }
        public string ElPastas { get; set; }
        public DateTime? TeorijosEgzData { get; set; }
        public DateTime? PraktikosEgzData { get; set; }
        public bool TeorijosEgzIslaikytas { get; set; }
        public bool PraktikosEgzIslaikytas { get; set; }
        public byte[] Nuotrauka { get; set; }

        public virtual ICollection<Apeliacija> Apeliacijas { get; set; }
        public virtual ICollection<Automobili> Automobilis { get; set; }
        public virtual ICollection<Egzamina> Egzaminas { get; set; }
        public virtual ICollection<VairuotojoPazymejima> VairuotojoPazymejimas { get; set; }
    }
}
