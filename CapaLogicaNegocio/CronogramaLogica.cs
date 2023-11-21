using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class CronogramaLogica
    {
        private CronogramaDatos CronogramaDatos;

        public CronogramaLogica()
        {
            CronogramaDatos = new CronogramaDatos();
        }

        public void CrearCronograma(Cronograma Cronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.CrearCronograma(Cronograma);
        }

        public List<Cronograma> LeerCronograma()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return CronogramaDatos.LeerCronograma();
        }

        public Cronograma LeerCronogramaPorID(int idCronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return CronogramaDatos.LeerCronogramaPorID(idCronograma);
        }

        public void ActualizarCronograma(Cronograma Cronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.ActualizarCronograma(Cronograma);
        }

        public void EliminarCronograma(int idCronograma)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            CronogramaDatos.EliminarCronograma(idCronograma);
        }
    }
}
