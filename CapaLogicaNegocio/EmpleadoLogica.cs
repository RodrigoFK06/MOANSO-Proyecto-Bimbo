using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class EmpleadoLogica
    {
        private EmpleadoDatos empleadoDatos;

        public EmpleadoLogica(string connectionString)
        {
            empleadoDatos = new EmpleadoDatos(connectionString);
        }

        public void CrearEmpleado(Empleado empleado)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            empleadoDatos.CrearEmpleado(empleado);
        }

        public List<Empleado> LeerEmpleados()
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return empleadoDatos.LeerEmpleados();
        }

        public Empleado LeerEmpleadoPorID(int idEmpleado)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            return empleadoDatos.LeerEmpleadoPorID(idEmpleado);
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            empleadoDatos.ActualizarEmpleado(empleado);
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            // Puedes agregar lógica adicional aquí antes de llamar a la capa de acceso a datos.
            empleadoDatos.EliminarEmpleado(idEmpleado);
        }
    }
}
