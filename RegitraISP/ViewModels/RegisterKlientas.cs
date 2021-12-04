using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegitraISP.ViewModels
{
    public class RegisterKlientas
    {
        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string AsmensKodas { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(30, ErrorMessage = "Slaptažodis negali viršyti 30 simbolių!")]
        public string Slaptazodis { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(30, ErrorMessage = "Slaptažodis negali viršyti 30 simbolių!")]
        [Compare("Slaptazodis", ErrorMessage = "Slaptažodžiai turi sutapti.")]
        public string Slaptazodis2 { get; set; }


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
        public byte[] Nuotrauka { get; set; }

    }
}
