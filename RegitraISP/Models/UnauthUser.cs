using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegitraISP.Models
{
    public class UnauthUser
    {
        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(12, ErrorMessage = "Vardas negali viršyti 12 simbolių!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Privalomas laukas!")]
        [MaxLength(30, ErrorMessage = "Slaptažodis negali viršyti 30 simbolių!")]
        public string Password { get; set; }
    }
}
