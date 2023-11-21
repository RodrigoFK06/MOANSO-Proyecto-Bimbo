using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class conexion2
    {
        private static readonly conexion2 _instancia = new conexion2();
        public static conexion2 Instancia
        {
            get { return conexion2._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.; Initial Catalog =bdProyectoBimbo;" +//"User ID=sa; Password=123"; 
                                "Integrated Security=true";

            return cn;
        }

    }
}
