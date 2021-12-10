using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegitraISP.ViewModels
{
    public class Nuotrauka
    {
        [Required(ErrorMessage = "Please choose profile image")]
        public IFormFile NuotraukaFile { get; set; }
    }
}
