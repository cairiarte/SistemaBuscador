using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name="Contraseña")]
        public string Password { get; set; }
    }
}
