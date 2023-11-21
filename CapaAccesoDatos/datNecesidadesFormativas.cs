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
    public class datNecesidadesFormativas
    {
        #region singleton
        private static readonly datNecesidadesFormativas _instancia = new datNecesidadesFormativas();
        public static datNecesidadesFormativas Instancia
        {
            get { return datNecesidadesFormativas._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entNecesidadesFormativas> ListarNecesidadesFormativas()
        {
            SqlCommand cmd = null;
            List<entNecesidadesFormativas> lista = new List<entNecesidadesFormativas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaNecesidadesFormativas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entNecesidadesFormativas Necesidad = new entNecesidadesFormativas();
                    Necesidad.idNecesidadesFormativas = Convert.ToInt32(dr["idNecesidadesFormativas"]);
                    Necesidad.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    Necesidad.FechaImplementacion = Convert.ToDateTime(dr["FechaImplementacion"]);
                    Necesidad.Necesidades = dr["Necesidades"].ToString();
                    Necesidad.idEstandarCompetencia = Convert.ToInt32(dr["idEstandarCompetencia"]);
                    Necesidad.idResolucionEvaluacionDesempeño = Convert.ToInt32(dr["idResolucionEvaluacionDesempeño"]);
                    lista.Add(Necesidad);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public bool InsertarNecesidadesFormativas(entNecesidadesFormativas necesidad)
        {
            SqlCommand cmd = null;
            bool insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNecesidadesFormativas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaCreacion", necesidad.FechaCreacion);
                cmd.Parameters.AddWithValue("@FechaImplementacion", necesidad.FechaImplementacion);
                cmd.Parameters.AddWithValue("@Necesidades", necesidad.Necesidades);
                cmd.Parameters.AddWithValue("@idEstandarCompetencia", necesidad.idEstandarCompetencia);
                cmd.Parameters.AddWithValue("@idResolucionEvaluacionDesempeño", necesidad.idResolucionEvaluacionDesempeño);


                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return insertado;
        }


        public DataTable ObtenerIdEstandarCompetencia()
        {
            using (SqlConnection connection = Conexion.Instancia.Conectar())
            {
                string query = "SELECT idEstandarCompetencia FROM EstandarCompetencia";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerIdResolucionEvaluacionDesempeno()
        {
            using (SqlConnection connection = Conexion.Instancia.Conectar())
            {
                string query = "SELECT idResolucionEvaluacionDesempeño FROM ResolucionEvaluacionDesempeño";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public int ObtenerSiguienteIdNecesidadesFormativas()
        {
            using (SqlConnection connection = Conexion.Instancia.Conectar())
            {
                string query = "SELECT ISNULL(MAX(idNecesidadesFormativas), 0) + 1 FROM NecesidadesFormativas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }


        public bool EliminarNecesidadesFormativas(int idNecesidadesFormativas)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarNecesidadesFormativas", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", idNecesidadesFormativas);
                    cn.Open();

                    int result = cmd.ExecuteNonQuery();

                    return result > 0; // Devuelve true si al menos una fila fue afectada (eliminada)
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public entNecesidadesFormativas ObtenerNecesidadFormativaPorId(int idNecesidadesFormativas)
        {
            SqlCommand cmd = null;
            entNecesidadesFormativas necesidadFormativa = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerNecesidadFormativaPorId", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idNecesidadesFormativas", idNecesidadesFormativas);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        // Crear una instancia de entNecesidadesFormativas y asignar los valores
                        necesidadFormativa = new entNecesidadesFormativas
                        {
                            idNecesidadesFormativas = Convert.ToInt32(dr["idNecesidadesFormativas"]),
                            FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]),
                            FechaImplementacion = Convert.ToDateTime(dr["FechaImplementacion"]),
                            Necesidades = dr["Necesidades"].ToString(),
                            idEstandarCompetencia = Convert.ToInt32(dr["idEstandarCompetencia"]),
                            idResolucionEvaluacionDesempeño = Convert.ToInt32(dr["idResolucionEvaluacionDesempeño"])
                        };

                        // Puedes agregar más campos según tu estructura de base de datos
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return necesidadFormativa;
        }

        public int ObtenerNotaTotal(int idResolucionEvaluacionDesempeño)
        {
            SqlCommand cmd = null;
            int notaTotal = 0;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerNotaTotalPorIdResolucionEvaluacionDesempeño", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idResolucionEvaluacionDesempeño", idResolucionEvaluacionDesempeño);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        notaTotal = Convert.ToInt32(dr["NotaTotal"]);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return notaTotal;
        }



        #endregion metodos

    }



}
