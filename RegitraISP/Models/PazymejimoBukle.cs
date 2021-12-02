using System;
using System.Collections.Generic;

#nullable disable

namespace RegitraISP.Models
{
    public partial class PazymejimoBukle
    {
        public PazymejimoBukle()
        {
            VairuotojoPazymejimas = new HashSet<VairuotojoPazymejima>();
        }

        public int IdPazymejimoBukle { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VairuotojoPazymejima> VairuotojoPazymejimas { get; set; }
    }
}
