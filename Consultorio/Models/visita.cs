using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class visita
    {
        public int idVisita { get; set; }
        public int idEmpleado { get; set; }
        public int idReceta { get; set; }
        public DateTime fechaActual { get; set; }
        public DateTime fechaProxima { get; set; }
        public int costo { get; set; }
        public string motivo { get; set; }
    }
}