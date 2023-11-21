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
    public class DetEvaDesempeñoDatos
    {
        #region singleton
        private static readonly DetEvaDesempeñoDatos _instancia = new DetEvaDesempeñoDatos();
        public static DetEvaDesempeñoDatos Instancia
        {
            get { return DetEvaDesempeñoDatos._instancia; }
        }
        #endregion singleton

        #region metodos

        public List<entDetEvaDesempeño> ListarDetEvaDesempeño()
        {
            SqlCommand cmd = null;
            List<entDetEvaDesempeño> lista = new List<entDetEvaDesempeño>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("GetDetallesEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entDetEvaDesempeño det = new entDetEvaDesempeño();
                    det.idDetalleEvaluacionDesempeño = Convert.ToInt16(dr["idDetalleEvaluacionDesempeño"]);
                    det.Nota = Convert.ToInt16(dr["Nota"]);
                    det.idPreguntasEvaluacionDesempeño = Convert.ToInt16(dr["idPreguntasEvaluacionDesempeño"]);
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

        public Boolean InsertarDetEvaDesempeño(entDetEvaDesempeño n)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertDetalleEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nota", n.Nota);
                cmd.Parameters.AddWithValue("@idPreguntasEvaluacionDesempeño", n.idPreguntasEvaluacionDesempeño);
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
        public Boolean EditarDetEvaDesempeño(entDetEvaDesempeño n)
        {
            SqlCommand cmd = null;
            Boolean Edito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("UpdateDetalleEvaluacionDesempeño", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalleEvaluacionDesempeño", n.idDetalleEvaluacionDesempeño);
                cmd.Parameters.AddWithValue("@Nota", n.Nota);
                cmd.Parameters.AddWithValue("@idPreguntasEvaluacionDesempeño", n.idPreguntasEvaluacionDesempeño);
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
