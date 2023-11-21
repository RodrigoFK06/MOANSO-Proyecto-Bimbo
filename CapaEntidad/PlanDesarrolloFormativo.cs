using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PlanDesarrolloFormativo
    {
        public int idPlanDesarrolloFormativo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Objetivos { get; set; }
        public int idCronograma { get; set; }
        public int idNecesidadesFormativas { get; set; }

    }
}
