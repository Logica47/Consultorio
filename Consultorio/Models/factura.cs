using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consultorio.Models
{
    public class factura
    {
        public int idFactura { get; set; }
        public int idCita { get; set; }
        public int idPaciente { get; set; }
        public int costo { get; set; }
        public DateTime fecha { get; set; }
    }
}