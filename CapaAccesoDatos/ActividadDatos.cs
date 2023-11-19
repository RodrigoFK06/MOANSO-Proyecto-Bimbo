using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ActividadDatos : Conexion
    {
        private string connectionString;

        public ActividadDatos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CrearActividad(Actividad actividad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "InsertActividad"; // Reemplaza con el nombre real del procedimiento almacenado de CrearActividad
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreActividad", actividad.NombreActividad);
                    cmd.Parameters.AddWithValue("@Descripcion", actividad.Descripcion);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public List<Actividad> LeerActividades()
        {
            List<Actividad> actividades = new List<Actividad>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "GetActividades"; // Reemplaza con el nombre real del procedimiento almacenado de LeerActividads
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Actividad actividad = new Actividad
                            {
                                idActividad = Convert.ToInt32(reader["idActividad"]),
                                NombreActividad = reader["NombreActividad"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                            };
                            actividades.Add(actividad);
                        }
                    }
                    connection.Close();
                }
            }
            return actividades;
        }


        public void ActualizarActividad(Actividad actividad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UpdateActividad"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarActividad
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idActividad", actividad.idActividad);
                    cmd.Parameters.AddWithValue("@NombreActividad", actividad.NombreActividad);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void EliminarActividad(int idActividad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DeleteActividad"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarActividad
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdActividad", idActividad);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
