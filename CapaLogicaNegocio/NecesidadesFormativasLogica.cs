using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class NecesidadesFormativasLogica
    {
        private NecesidadesFormativasDatos NecesidadesFormativasDatos;

        public NecesidadesFormativasLogica()
        {
            NecesidadesFormativasDatos = new NecesidadesFormativasDatos();
        }

        public void CrearNecesidadesFormativas(NecesidadesFormativas NecesidadesFormativas)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            NecesidadesFormativasDatos.CrearNecesidadesFormativas(NecesidadesFormativas);
        }

        public List<NecesidadesFormativas> LeerNecesidadesFormativas()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return NecesidadesFormativasDatos.LeerNecesidadesFormativas();
        }

        public NecesidadesFormativas LeerNecesidadesFormativasPorID(int idNecesidadesFormativas)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return NecesidadesFormativasDatos.LeerNecesidadesFormativasPorID(idNecesidadesFormativas);
        }

        public void ActualizarNecesidadesFormativas(NecesidadesFormativas NecesidadesFormativas)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            NecesidadesFormativasDatos.ActualizarNecesidadesFormativas(NecesidadesFormativas);
        }

        public void EliminarNecesidadesFormativas(int idNecesidadesFormativas)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            NecesidadesFormativasDatos.EliminarNecesidadesFormativas(idNecesidadesFormativas);
        }
    }
}
