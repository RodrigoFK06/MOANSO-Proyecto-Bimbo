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

        public ActividadLogica()
        {
            ActividadDatos = new ActividadDatos();
        }

        public void CrearActividad(Actividad Actividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            ActividadDatos.CrearActividad(Actividad);
        }

        public List<Actividad> LeerActividad()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return ActividadDatos.LeerActividad();
        }

        public Actividad LeerActividadPorID(int idActividad)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return ActividadDatos.LeerActividadPorID(idActividad);
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
