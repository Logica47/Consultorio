using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class cita
    {
        public int idCita { get; set; }
        public int idEmpleado { get; set; }
        public int idPaciente { get; set; }
        public DateTime fechaCita { get; set; }
    }
}