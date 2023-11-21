using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class PregEvaDesempeñoDatos
    {
        #region singleton
        private static readonly PregEvaDesempeñoDatos _instancia = new PregEvaDesempeñoDatos();
        public static PregEvaDesempeñoDatos Instancia
        {
            get { return PregEvaDesempeñoDatos._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entPregEvaDesempeño> ListarPregEvaDesempeño()
        {
            SqlCommand cmd = null;
            List<entPregEvaDesempeño> lista = new List<entPregEvaDesempeño>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("GetPreguntasEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPregEvaDesempeño det = new entPregEvaDesempeño();
                    det.idPreguntasEvaluacionDesempeño = Convert.ToInt16(dr["idPreguntasEvaluacionDesempeño"]);
                    det.Pregunta = dr["Pregunta"].ToString();
                    det.Opcion1 = dr["Opcion1"].ToString();
                    det.Opcion2 = dr["Opcion2"].ToString();
                    det.Opcion3 = dr["Opcion3"].ToString();
                    det.Opcion4 = dr["Opcion4"].ToString();
                    det.Respuesta = dr["Respuesta"].ToString();
                    det.idEvaluacionDesempeño = Convert.ToInt16(dr["idEvaluacionDesempeño"]);
                    lista.Add(det);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarPregEvaDesempeño(entPregEvaDesempeño p)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertPreguntasEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pregunta", p.Pregunta);
                cmd.Parameters.AddWithValue("@Opcion1", p.Opcion1);
                cmd.Parameters.AddWithValue("@Opcion2", p.Opcion2);
                cmd.Parameters.AddWithValue("@Opcion3", p.Opcion3);
                cmd.Parameters.AddWithValue("@Opcion4", p.Opcion4);
                cmd.Parameters.AddWithValue("@Respuesta", p.Respuesta);
                cmd.Parameters.AddWithValue("@idEvaluacionDesempeño", p.idEvaluacionDesempeño);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        public Boolean EliminarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeletePreguntasEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPreguntasEvaluacionDesempeño", preg.idPreguntasEvaluacionDesempeño);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return elimina;
        }
        public Boolean EditarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            SqlCommand cmd = null;
            Boolean Edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("UpdatePreguntasEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPreguntasEvaluacionDesempeño", preg.idPreguntasEvaluacionDesempeño);
                cmd.Parameters.AddWithValue("@Pregunta", preg.Pregunta);
                cmd.Parameters.AddWithValue("@Opcion1", preg.Opcion1);
                cmd.Parameters.AddWithValue("@Opcion2", preg.Opcion2);
                cmd.Parameters.AddWithValue("@Opcion3", preg.Opcion3);
                cmd.Parameters.AddWithValue("@Opcion4", preg.Opcion4);
                cmd.Parameters.AddWithValue("@Respuesta", preg.Respuesta);
                cmd.Parameters.AddWithValue("@idEvaluacionDesempeño", preg.idEvaluacionDesempeño);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { Edito = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return Edito;
        }
        #endregion metodos
    }
}
