using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class EgzaminoTipa
    {
        public EgzaminoTipa()
        {
            Egzaminas = new HashSet<Egzamina>();
        }

        public int IdEgzaminoTipas { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Egzamina> Egzaminas { get; set; }
    }
}
