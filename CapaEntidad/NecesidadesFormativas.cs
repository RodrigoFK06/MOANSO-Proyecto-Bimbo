using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NecesidadesFormativas
    {
        public int idNecesidadesFormativas { get; set; }
        public string Necesidades { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaImplementacion { get; set; }
        public int idEstandarCompetencia { get; set; }
        public int idResolucionEvaluacionDesempeño { get; set; }

    }
}
