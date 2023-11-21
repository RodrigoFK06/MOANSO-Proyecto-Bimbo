using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class EmpleadoDatos : Conexion
    {
        public List<Empleado> LeerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetEmpleados"; // Reemplaza con el nombre real del procedimiento almacenado de LeerEmpleados

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["NombreEmpleado"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"]),
                                Puesto = reader["Puesto"].ToString(),
                                Area = reader["Area"].ToString()
                            };
                            empleados.Add(empleado);
                        }
                    }
                    conexion.Close();
                }
            }
            return empleados;
        }

        public void CrearEmpleado(Empleado empleado)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "InsertEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de CrearEmpleado

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    // cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Area", empleado.Area);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public Empleado LeerEmpleadoPorID(int idEmpleado)
        {
            Empleado empleado = null;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetEmpleadoPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerEmpleadoPorID
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["NombreEmpleado"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"]),
                                Puesto = reader["Puesto"].ToString(),
                                Area = reader["Area"].ToString()
                            };
                        }
                    }
                    conexion.Close();
                }
            }
            return empleado;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "UpdateEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarEmpleado
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Area", empleado.Area);

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "DeleteEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarEmpleado
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}
