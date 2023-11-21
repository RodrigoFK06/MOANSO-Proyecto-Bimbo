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
    public class datEncuesta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEncuesta _instancia = new datEncuesta();
        //privado para evitar la instanciación directa
        public static datEncuesta Instancia
        {
            get
            {
                return datEncuesta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listadoEncuesta
        public List<entEncuesta> ListarEncuesta()
        {
            SqlCommand cmd = null;
            List<entEncuesta> lista = new List<entEncuesta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("GetEncuestas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEncuesta en = new entEncuesta();
                    en.idEncuesta = Convert.ToInt32(dr["idEncuesta"]);
                    en.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                    en.FechaCierre = Convert.ToDateTime(dr["FechaCierre"]);
                    en.Titulo = dr["Titulo"].ToString();
                    en.idArea = Convert.ToInt32(dr["idArea"]);
                    en.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    lista.Add(en);
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
        #endregion


    }
}
