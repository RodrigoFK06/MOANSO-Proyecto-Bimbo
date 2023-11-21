using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=TONY; Initial Catalog = ProyectoBimboBD;" +//"User ID=sa; Password=123";
                                "Integrated Security=true";

            return cn;
        }

        private readonly string cadenaConexion = "Data Source=TONY;Initial Catalog=ProyectoBimboBD;Integrated Security=True;";


        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
