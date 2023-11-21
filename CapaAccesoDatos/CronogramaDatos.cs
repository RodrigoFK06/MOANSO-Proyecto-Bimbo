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
    public class CronogramaDatos : Conexion
    {
        public List<Cronograma> LeerCronograma()
        {
            List<Cronograma> Cronogramas = new List<Cronograma>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetCronogramas"; // Reemplaza con el nombre real del procedimiento almacenado de LeerCronograma

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cronograma Cronograma = new Cronograma
                            {
                                idCronograma = Convert.ToInt32(reader["idCronograma"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                idActividad = Convert.ToInt32(reader["idActividad"]),
                                idEmpleado = Convert.ToInt32(reader["idEmpleado"]),
                                idResolucionEncuesta = Convert.ToInt32(reader["idResolucionEncuesta"]),
                            };
                            Cronogramas.Add(Cronograma);
                        }
                    }
                    conexion.Close();
                }
            }
            return Cronogramas;
        }

        public void CrearCronograma(Cronograma Cronograma)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "InsertCronograma"; // Reemplaza con el nombre real del procedimiento almacenado de CrearCronograma

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Titulo", Cronograma.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", Cronograma.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaInicio", Cronograma.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", Cronograma.FechaFin);
                    cmd.Parameters.AddWithValue("@idActividad", Cronograma.idActividad);
                    cmd.Parameters.AddWithValue("@idEmpleado", Cronograma.idEmpleado);
                    cmd.Parameters.AddWithValue("@idResolucionEncuesta", Cronograma.idResolucionEncuesta);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public Cronograma LeerCronogramaPorID(int idCronograma)
        {
            Cronograma Cronograma = null;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetCronogramaPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerCronogramaPorID
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCronograma", idCronograma);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Cronograma = new Cronograma
                            {
                                idCronograma = Convert.ToInt32(reader["idCronograma"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                idActividad = Convert.ToInt32(reader["idActividad"]),
                                idEmpleado = Convert.ToInt32(reader["idEmpleado"]),
                                idResolucionEncuesta = Convert.ToInt32(reader["idResolucionEncuesta"]),
                            };
                        }
                    }
                    conexion.Close();
                }
            }
            return Cronograma;
        }

        public void ActualizarCronograma(Cronograma Cronograma)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "UpdateCronograma"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarCronograma
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulo", Cronograma.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", Cronograma.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaInicio", Cronograma.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", Cronograma.FechaFin);
                    cmd.Parameters.AddWithValue("@idActividad", Cronograma.idActividad);
                    cmd.Parameters.AddWithValue("@idEmpleado", Cronograma.idEmpleado);
                    cmd.Parameters.AddWithValue("@idResolucionEncuesta", Cronograma.idResolucionEncuesta);

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarCronograma(int idCronograma)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "DeleteCronograma"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarCronograma
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCronograma", idCronograma);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}