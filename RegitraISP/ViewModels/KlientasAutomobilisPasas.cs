using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegitraISP.Models;
using System.ComponentModel.DataAnnotations;

namespace RegitraISP.ViewModels
{
    public class KlientasAutomobilisPasas
    {

        public List<Klienta> Klientai { get; set; }
        public List<Automobili> Automobiliai { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string Vin { get; set; }
        public int tabelio_nr { get; set; }
        public string asmens_kodas { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string Marke { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string Modelis { get; set; }
        public DateTime PagaminimoMetai { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string PaskutineRegSalis { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string PirmojiRegSalis { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string ValstybiniaiNumeriai { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string AutomobilioSpalva { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Asmens kodas negali viršyti 12 simbolių!")]
        public string KuroTipas { get; set; }

        public int Co2Kiekis { get; set; }

        public int Svoris { get; set; }

        public float VariklioLitrazas { get; set; }

        public int KilovatuSkaicius { get; set; }
    }
}
