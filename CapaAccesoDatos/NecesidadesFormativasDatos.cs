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
    public class NecesidadesFormativasDatos : Conexion
    {
        public List<NecesidadesFormativas> LeerNecesidadesFormativas()
        {
            List<NecesidadesFormativas> necesidadesFormativas = new List<NecesidadesFormativas>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetNecesidadesFormativas"; // Reemplaza con el nombre real del procedimiento almacenado de LeerNecesidadesFormativas

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NecesidadesFormativas NecesidadesFormativas = new NecesidadesFormativas
                            {
                                idNecesidadesFormativas = Convert.ToInt32(reader["idNecesidadesFormativas"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaImplementacion = Convert.ToDateTime(reader["FechaImplementacion"]),
                                Necesidades = reader["Necesidades"].ToString(),
                                idEstandarCompetencia = Convert.ToInt32(reader["idEstandarCompetencia"]),
                                idResolucionEvaluacionDesempeño = Convert.ToInt32(reader["idResolucionEvaluacionDesempeño"]),
                            };
                            necesidadesFormativas.Add(NecesidadesFormativas);
                        }
                    }
                    conexion.Close();
                }
            }
            return necesidadesFormativas;
        }

        public void CrearNecesidadesFormativas(NecesidadesFormativas NecesidadesFormativas)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "InsertNecesidadesFormativas"; // Reemplaza con el nombre real del procedimiento almacenado de CrearNecesidadesFormativas

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FechaCreacion", NecesidadesFormativas.FechaCreacion);
                    cmd.Parameters.AddWithValue("@FechaImplementacion", NecesidadesFormativas.FechaImplementacion);
                    cmd.Parameters.AddWithValue("@Necesidades", NecesidadesFormativas.Necesidades);
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", NecesidadesFormativas.idEstandarCompetencia);
                    cmd.Parameters.AddWithValue("@idResolucionEvaluacionDesempeño", NecesidadesFormativas.idResolucionEvaluacionDesempeño);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public NecesidadesFormativas LeerNecesidadesFormativasPorID(int idNecesidadesFormativas)
        {
            NecesidadesFormativas NecesidadesFormativas = null;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetNecesidadesFormativasPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerNecesidadesFormativasPorID
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", idNecesidadesFormativas);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NecesidadesFormativas = new NecesidadesFormativas
                            {
                                idNecesidadesFormativas = Convert.ToInt32(reader["idNecesidadesFormativas"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaImplementacion = Convert.ToDateTime(reader["FechaImplementacion"]),
                                Necesidades = reader["Necesidades"].ToString(),
                                idEstandarCompetencia = Convert.ToInt32(reader["idEstandarCompetencia"]),
                                idResolucionEvaluacionDesempeño = Convert.ToInt32(reader["idResolucionEvaluacionDesempeño"]),
                            };
                        }
                    }
                    conexion.Close();
                }
            }
            return NecesidadesFormativas;
        }

        public void ActualizarNecesidadesFormativas(NecesidadesFormativas NecesidadesFormativas)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "UpdateNecesidadesFormativas"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarNecesidadesFormativas
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaCreacion", NecesidadesFormativas.FechaCreacion);
                    cmd.Parameters.AddWithValue("@FechaImplementacion", NecesidadesFormativas.FechaImplementacion);
                    cmd.Parameters.AddWithValue("@Necesidades", NecesidadesFormativas.Necesidades);
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", NecesidadesFormativas.idEstandarCompetencia);
                    cmd.Parameters.AddWithValue("@idResolucionEvaluacionDesempeño", NecesidadesFormativas.idResolucionEvaluacionDesempeño);

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarNecesidadesFormativas(int idNecesidadesFormativas)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "DeleteNecesidadesFormativas"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarNecesidadesFormativas
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", idNecesidadesFormativas);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}
