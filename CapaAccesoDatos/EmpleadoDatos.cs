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
        private string connectionString;

        public EmpleadoDatos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CrearEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "CrearEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de CrearEmpleado
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Area", empleado.Area);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public List<Empleado> LeerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "GetEmpleados"; // Reemplaza con el nombre real del procedimiento almacenado de LeerEmpleados
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
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
                    connection.Close();
                }
            }
            return empleados;
        }

        public Empleado LeerEmpleadoPorID(int idEmpleado)
        {
            Empleado empleado = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "LeerEmpleadoPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerEmpleadoPorID
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"]),
                                Puesto = reader["Puesto"].ToString(),
                                Area = reader["Area"].ToString()
                            };
                        }
                    }
                    connection.Close();
                }
            }
            return empleado;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "ActualizarEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarEmpleado
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);
                    cmd.Parameters.AddWithValue("@Puesto", empleado.Puesto);
                    cmd.Parameters.AddWithValue("@Area", empleado.Area);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "EliminarEmpleado"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarEmpleado
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
