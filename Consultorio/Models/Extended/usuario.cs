using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Consultorio.Models
{   
    [MetadataType(typeof(UserMetaData))]
    public partial class usuario
    {
        internal static string emailID;

        public string VerificarContraseña { get; set; }
    }

    public class UserMetaData
    {
        [Display(Name = "Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Su nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Su apellido es obligatorio")]
        public string Apellido { get; set; }

        [Display(Name = "Correo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Su correo es obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public string FechaNacimiento { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Su contraseña es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Minimo 6 caracteres permitidos")]
        public string Contraseña { get; set; }

       
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Contraseña",ErrorMessage ="Las contraseñas no coinciden")]
        public string VerificarContraseña { get; set; }

    }
}