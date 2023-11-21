using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class PlanDesarrolloFormativoLogica
    {
        private PlanDesarrolloFormativoDatos PlanDesarrolloFormativoDatos;

        public PlanDesarrolloFormativoLogica()
        {
            PlanDesarrolloFormativoDatos = new PlanDesarrolloFormativoDatos();
        }

        public void CrearPlanDesarrolloFormativo(PlanDesarrolloFormativo PlanDesarrolloFormativo)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            PlanDesarrolloFormativoDatos.CrearPlanDesarrolloFormativo(PlanDesarrolloFormativo);
        }

        public List<PlanDesarrolloFormativo> LeerPlanDesarrolloFormativo()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return PlanDesarrolloFormativoDatos.LeerPlanDesarrolloFormativo();
        }

        public PlanDesarrolloFormativo LeerPlanDesarrolloFormativoPorID(int idPlanDesarrolloFormativo)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return PlanDesarrolloFormativoDatos.LeerPlanDesarrolloFormativoPorID(idPlanDesarrolloFormativo);
        }

        public void ActualizarPlanDesarrolloFormativo(PlanDesarrolloFormativo PlanDesarrolloFormativo)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            PlanDesarrolloFormativoDatos.ActualizarPlanDesarrolloFormativo(PlanDesarrolloFormativo);
        }

        public void EliminarPlanDesarrolloFormativo(int idPlanDesarrolloFormativo)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            PlanDesarrolloFormativoDatos.EliminarPlanDesarrolloFormativo(idPlanDesarrolloFormativo);
        }
        public PlanDesarrolloFormativo BuscarProductoId(int idPlanDesarrolloFormativo)
        {
            try
            {
                return PlanDesarrolloFormativoDatos.LeerPlanDesarrolloFormativoPorID(idPlanDesarrolloFormativo);
            }
            catch (Exception e) { throw e; }
        }
    }
}
