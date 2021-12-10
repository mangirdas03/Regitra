using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace RegitraISP.Models
{
    public partial class Klienta// : IValidatableObject
    {
        public Klienta()
        {
            Apeliacijas = new HashSet<Apeliacija>();
            Automobilis = new HashSet<Automobili>();
            Egzaminas = new HashSet<Egzamina>();
            VairuotojoPazymejimas = new HashSet<VairuotojoPazymejima>();
        }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string AsmensKodas { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(30, ErrorMessage = "Slaptažodis negali viršyti 30 simbolių!")]
        public string Slaptazodis { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(25, ErrorMessage = "Vardas negali viršyti 25 simbolių!")]
        public string Vardas { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(25, ErrorMessage = "Pavardė negali viršyti 25 simbolių!")]
        public string Pavarde { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(10, ErrorMessage = "Numeris negali viršyti 10 simbolių!")]
        public string TelNr { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        public string ElPastas { get; set; }

        public DateTime? TeorijosEgzData { get; set; }
        public DateTime? PraktikosEgzData { get; set; }

        public bool TeorijosEgzIslaikytas { get; set; }
        public bool PraktikosEgzIslaikytas { get; set; }

        public string Nuotrauka { get; set; }

        public virtual ICollection<Apeliacija> Apeliacijas { get; set; }
        public virtual ICollection<Automobili> Automobilis { get; set; }
        public virtual ICollection<Egzamina> Egzaminas { get; set; }
        public virtual ICollection<VairuotojoPazymejima> VairuotojoPazymejimas { get; set; }


        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    //if (PraktikosEgzIslaikytas == true)
        //    //{
        //    //    yield return new ValidationResult("Pasirinkite datą.", new[] { nameof(PraktikosEgzData) });
        //    //}
        //    //if (TeorijosEgzIslaikytas == true)
        //    //{
        //    //    yield return new ValidationResult("Pasirinkite datą.", new[] { nameof(TeorijosEgzData) });
        //    //}

        //}
    }
}
