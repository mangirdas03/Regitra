using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Filiala
    {
        public Filiala()
        {
            Darbuotojas = new HashSet<Darbuotoja>();
            Egzaminas = new HashSet<Egzamina>();
        }

        public string Gatve { get; set; }
        public int GatvesNr { get; set; }
        public bool? TeorijosEgz { get; set; }
        public bool? PraktikosEgz { get; set; }
        public int IdFilialas { get; set; }
        public string FkMiestaspavadinimas { get; set; }

        public virtual Miesta FkMiestaspavadinimasNavigation { get; set; }
        public virtual ICollection<Darbuotoja> Darbuotojas { get; set; }
        public virtual ICollection<Egzamina> Egzaminas { get; set; }
    }
}
