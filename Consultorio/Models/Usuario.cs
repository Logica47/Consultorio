//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Contraseña { get; set; }
        public bool VerificarCorreo { get; set; }
        public System.Guid CodigoActivacion { get; set; }
    }
}
