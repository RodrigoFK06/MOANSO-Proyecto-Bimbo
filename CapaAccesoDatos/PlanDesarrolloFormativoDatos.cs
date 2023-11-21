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
    public class PlanDesarrolloFormativoDatos : Conexion
    {
        public List<PlanDesarrolloFormativo> LeerPlanDesarrolloFormativo()
        {
            List<PlanDesarrolloFormativo> planDesarrolloFormativos = new List<PlanDesarrolloFormativo>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetPlanesDesarrolloFormativo"; // Reemplaza con el nombre real del procedimiento almacenado de LeerPlanDesarrolloFormativo

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PlanDesarrolloFormativo planDesarrolloFormativo = new PlanDesarrolloFormativo
                            {
                                idPlanDesarrolloFormativo = Convert.ToInt32(reader["idPlanDesarrolloFormativo"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                Objetivos = reader["Objetivos"].ToString(),
                                idCronograma = Convert.ToInt32(reader["idCronograma"]),
                                idNecesidadesFormativas = Convert.ToInt32(reader["idNecesidadesFormativas"]),
                            };
                            planDesarrolloFormativos.Add(planDesarrolloFormativo);
                        }
                    }
                    conexion.Close();
                }
            }
            return planDesarrolloFormativos;
        }

        public void CrearPlanDesarrolloFormativo(PlanDesarrolloFormativo PlanDesarrolloFormativo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "InsertPlanDesarrolloFormativo"; // Reemplaza con el nombre real del procedimiento almacenado de CrearPlanDesarrolloFormativo

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FechaCreacion", PlanDesarrolloFormativo.FechaCreacion);
                    cmd.Parameters.AddWithValue("@FechaInicio", PlanDesarrolloFormativo.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", PlanDesarrolloFormativo.FechaFin);
                    cmd.Parameters.AddWithValue("@Objetivos", PlanDesarrolloFormativo.Objetivos);
                    cmd.Parameters.AddWithValue("@idCronograma", PlanDesarrolloFormativo.idCronograma);
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", PlanDesarrolloFormativo.idNecesidadesFormativas);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public PlanDesarrolloFormativo LeerPlanDesarrolloFormativoPorID(int idPlanDesarrolloFormativo)
        {
            PlanDesarrolloFormativo PlanDesarrolloFormativo = null;
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "GetPlanDesarrolloFormativoPorID"; // Reemplaza con el nombre real del procedimiento almacenado de LeerPlanDesarrolloFormativoPorID
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPlanDesarrolloFormativo", idPlanDesarrolloFormativo);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PlanDesarrolloFormativo = new PlanDesarrolloFormativo
                            {
                                idPlanDesarrolloFormativo = Convert.ToInt32(reader["idPlanDesarrolloFormativo"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                Objetivos = reader["Objetivos"].ToString(),
                                idCronograma = Convert.ToInt32(reader["idCronograma"]),
                                idNecesidadesFormativas = Convert.ToInt32(reader["idNecesidadesFormativas"]),
                            };
                        }
                    }
                    conexion.Close();
                }
            }
            return PlanDesarrolloFormativo;
        }

        public void ActualizarPlanDesarrolloFormativo(PlanDesarrolloFormativo PlanDesarrolloFormativo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "UpdatePlanDesarrolloFormativo"; // Reemplaza con el nombre real del procedimiento almacenado de ActualizarPlanDesarrolloFormativo
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaCreacion", PlanDesarrolloFormativo.FechaCreacion);
                    cmd.Parameters.AddWithValue("@FechaInicio", PlanDesarrolloFormativo.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", PlanDesarrolloFormativo.FechaFin);
                    cmd.Parameters.AddWithValue("@Objetivos", PlanDesarrolloFormativo.Objetivos);
                    cmd.Parameters.AddWithValue("@idCronograma", PlanDesarrolloFormativo.idCronograma);
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", PlanDesarrolloFormativo.idNecesidadesFormativas);

                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarPlanDesarrolloFormativo(int idPlanDesarrolloFormativo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string query = "DeletePlanDesarrolloFormativo"; // Reemplaza con el nombre real del procedimiento almacenado de EliminarPlanDesarrolloFormativo
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPlanDesarrolloFormativo", idPlanDesarrolloFormativo);


                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }
    }
}
