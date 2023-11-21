using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEncuesta
    {
        public int idEncuesta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Titulo { get; set; }
        public int idArea { get; set; }
        public int idEmpleado { get; set; }
    }
}
