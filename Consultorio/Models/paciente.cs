using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class paciente
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoSangre { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}