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
    public class datAreas
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAreas _instancia = new datAreas();
        //privado para evitar la instanciación directa
        public static datAreas Instancia
        {
            get
            {
                return datAreas._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Area
        public List<entAreas> ListarAreas()
        {
            SqlCommand cmd = null;
            List<entAreas> lista = new List<entAreas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("GetAreas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAreas ar = new entAreas();
                    ar.idArea = Convert.ToInt32(dr["idArea"]);
                    ar.Nombre = dr["Nombre"].ToString();
                    ar.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(ar);
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

        //////////////////////////////////EditaArea
        public Boolean ModificarArea(entAreas ar)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("UpdateArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArea", ar.idArea);
                cmd.Parameters.AddWithValue("@Nombre", ar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", ar.Descripcion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        /////////////////////////InsertaArea
        public Boolean RegistrarArea(entAreas ar)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", ar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", ar.Descripcion);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }


    }
}
