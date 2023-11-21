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
    public class datEstandarCompetencia
    {
        #region singleton
        private static readonly datEstandarCompetencia _instancia = new datEstandarCompetencia();
        public static datEstandarCompetencia Instancia
        {
            get { return datEstandarCompetencia._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entEstandarCompetencia> ListarEstandarCompetencia()
        {
            SqlCommand cmd = null;
            List<entEstandarCompetencia> lista = new List<entEstandarCompetencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaEstandarCompetencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entEstandarCompetencia estandar = new entEstandarCompetencia();
                    estandar.IdEstandarCompetencia = Convert.ToInt32(dr["idEstandarCompetencia"]);
                    estandar.NivelRequerido = Convert.ToInt32(dr["NivelRequerido"]);
                    estandar.Descripcion = dr["Descripcion"].ToString();
                    estandar.IdArea = Convert.ToInt32(dr["idArea"]);
                    lista.Add(estandar);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public void InsertarEstandarCompetencia(entEstandarCompetencia estandar)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEstandarCompetencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NivelRequerido", estandar.NivelRequerido);
                cmd.Parameters.AddWithValue("@Descripcion", estandar.Descripcion);
                cmd.Parameters.AddWithValue("@idArea", estandar.IdArea);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }

        public bool EditarEstandarCompetencia(entEstandarCompetencia estandar)
        {
            SqlCommand cmd = null;
            bool editado = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEditarEstandarCompetencia", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", estandar.IdEstandarCompetencia);
                    cmd.Parameters.AddWithValue("@NivelRequerido", estandar.NivelRequerido);
                    cmd.Parameters.AddWithValue("@Descripcion", estandar.Descripcion);
                    cmd.Parameters.AddWithValue("@idArea", estandar.IdArea);
                    // Agrega más parámetros según tu estructura de base de datos

                    cn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        editado = true;
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

            return editado;
        }

        public bool EliminarEstandarCompetencia(int idEstandarCompetencia)
        {
            SqlCommand cmd = null;
            bool eliminado = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spEliminarEstandarCompetencia", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", idEstandarCompetencia);
                    cn.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        eliminado = true;
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

            return eliminado;
        }


        public DataTable ObtenerIdArea()
        {
            using (SqlConnection connection = Conexion.Instancia.Conectar())
            {
                string query = "SELECT idArea FROM Area";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public entEstandarCompetencia ObtenerEstandarCompetenciaPorId(int idEstandarCompetencia)
        {
            SqlCommand cmd = null;
            entEstandarCompetencia estandar = null;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerEstandarCompetenciaPorId", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", idEstandarCompetencia);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        estandar = new entEstandarCompetencia();
                        estandar.IdEstandarCompetencia = Convert.ToInt32(dr["idEstandarCompetencia"]);
                        estandar.NivelRequerido = Convert.ToInt32(dr["NivelRequerido"]);
                        estandar.Descripcion = dr["Descripcion"].ToString();
                        estandar.IdArea = Convert.ToInt32(dr["idArea"]);
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

            return estandar;
        }

        public int ObtenerSiguienteIdEstandarCompetencia()
        {
            SqlCommand cmd = null;
            int siguienteId = 0;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerSiguienteIdEstandarCompetencia", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() && !dr.IsDBNull(0))
                    {
                        siguienteId = Convert.ToInt32(dr[0]);
                    }
                }
            }
            catch (Exception e)
            {
                // Manejar la excepción según tus necesidades
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return siguienteId;
        }

        public int ObtenerNivelRequerido(int idEstandarCompetencia)
        {
            SqlCommand cmd = null;
            int nivelRequerido = 0;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cmd = new SqlCommand("spObtenerNivelRequeridoPorIdEstandarCompetencia", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEstandarCompetencia", idEstandarCompetencia);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        nivelRequerido = Convert.ToInt32(dr["NivelRequerido"]);
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

            return nivelRequerido;
        }



        #endregion metodos
    }
}
