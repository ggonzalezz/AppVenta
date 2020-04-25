using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppVenta.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage ="Campo Nombre Obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo Apellido Obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo DNI Obligatorio")]
        public string DNI { get; set; }


        [Required(ErrorMessage = "Campo Numero de telefono Obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "El formato telefonico no es valido")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El Campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Escriba un correo valido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage ="El campo contrase;a es obligatorio")]
        [StringLength(100, ErrorMessage ="El numero de caracteres de {0} debe ser almenos {2}.", MinimumLength =8)]
        public string Password { get; set; }



    }
}










