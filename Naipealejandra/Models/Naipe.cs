using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naipealejandra.Models
{
    public class Naipe
    {
        [Key]
        [Required]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Por favor ingrese una sola letra")]
        [Display(Name = "Inserte letra de la A a la K")]
        public string IdNaipe { get; set; }

        [Required] // Sea obligatorio
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 y 60 caracteres")]
        [Display(Name = "Nombre de la carta")]
        public string NombreNaipe { get; set; }

        [Url]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")] // Sea obligatorio
        [Display(Name = "Link de la carta")]
        public string LinkNaipe { get; set; }
    }
}
