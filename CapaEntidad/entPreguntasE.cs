using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPreguntasE
    {
        public int idPreguntasEncuesta { get; set; }
        public string Pregunta { get; set; }
        public string Opcion1 { get; set; }
        public string Opcion2 { get; set; }
        public string Opcion3 { get; set; }
        public string Opcion4 { get; set; }
        public int idEncuesta { get; set; }
    }
}
