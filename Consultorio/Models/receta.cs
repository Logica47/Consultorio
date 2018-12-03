using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class receta
    {
        public int idReceta { get; set; }
        public int idPaciente { get; set; }
        public int idEmpleado { get; set; }
        public string detalle { get; set; }
        public DateTime fecha { get; set; }
    }
}