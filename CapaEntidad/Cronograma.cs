using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cronograma
    {
        public int idCronograma { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int idResolucionEncuesta { get; set; }
        public int idEmpleado { get; set; }
        public int idActividad { get; set; }


    }
}
