using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ActividadLogica
    {
        private ActividadDatos ActividadDatos;

        public ActividadLogica(string connectionString)
        {
            ActividadDatos = new ActividadDatos(connectionString);
        }

        public void CrearActividad(Actividad Actividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.CrearActividad(Actividad);
        }

        public List<Actividad> LeerActividades()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return ActividadDatos.LeerActividades();
        }



        public void ActualizarActividad(Actividad Actividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.ActualizarActividad(Actividad);
        }

        public void EliminarActividad(int idActividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.EliminarActividad(idActividad);
        }
    }
}
