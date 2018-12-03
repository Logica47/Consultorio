using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class consulta
    {
        public int idConsulta { get; set; }
        public int idEmpleado { get; set; }
        public int idPaciente { get; set; }
        public int costo { get; set; }
        public string motivo { get; set; }
        public DateTime fecha { get; set; }
    }
}