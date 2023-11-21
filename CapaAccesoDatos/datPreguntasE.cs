using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaAccesoDatos
{
    public class datPreguntasE
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPreguntasE _instancia = new datPreguntasE();
        //privado para evitar la instanciación directa
        public static datPreguntasE Instancia
        {
            get
            {
                return datPreguntasE._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listadoPreguntas
        public List<entPreguntasE> ListarPreguntas()
        {
            SqlCommand cmd = null;
            List<entPreguntasE> lista = new List<entPreguntasE>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("GetPreguntasEncuesta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPreguntasE pr = new entPreguntasE();
                    pr.idPreguntasEncuesta = Convert.ToInt32(dr["idPreguntasEncuesta"]);
                    pr.Pregunta = dr["Pregunta"].ToString();
                    pr.Opcion1 = dr["Opcion1"].ToString();
                    pr.Opcion2 = dr["Opcion2"].ToString();
                    pr.Opcion3 = dr["Opcion3"].ToString();
                    pr.Opcion4 = dr["Opcion4"].ToString();
                    pr.idEncuesta = Convert.ToInt32(dr["idEncuesta"]);
                    lista.Add(pr);
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


        //////////////////////////////////EditaPreguntas
        public Boolean ModificarPreguntas(entPreguntasE pr)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("UpdatePreguntasEncuesta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPreguntasEncuesta", pr.idPreguntasEncuesta);
                cmd.Parameters.AddWithValue("@Pregunta", pr.Pregunta);
                cmd.Parameters.AddWithValue("@Opcion1", pr.Opcion1);
                cmd.Parameters.AddWithValue("@Opcion2", pr.Opcion2);
                cmd.Parameters.AddWithValue("@Opcion3", pr.Opcion3);
                cmd.Parameters.AddWithValue("@Opcion4", pr.Opcion4);
                cmd.Parameters.AddWithValue("@idEncuesta", pr.idEncuesta);

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
        /////////////////////////InsertaPreguntas
        public Boolean RegistrarPreguntas(entPreguntasE pr)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertPreguntasEncuesta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pregunta", pr.Pregunta);
                cmd.Parameters.AddWithValue("@Opcion1", pr.Opcion1);
                cmd.Parameters.AddWithValue("@Opcion2", pr.Opcion2);
                cmd.Parameters.AddWithValue("@Opcion3", pr.Opcion3);
                cmd.Parameters.AddWithValue("@Opcion4", pr.Opcion4);
                cmd.Parameters.AddWithValue("@idEncuesta", pr.idEncuesta);
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
        #endregion
    }
}
