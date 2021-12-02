using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class Miesta
    {
        public Miesta()
        {
            Filialas = new HashSet<Filiala>();
        }

        public string Pavadinimas { get; set; }

        public virtual ICollection<Filiala> Filialas { get; set; }
    }
}
