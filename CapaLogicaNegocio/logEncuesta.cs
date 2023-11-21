using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logEncuesta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEncuesta _instancia = new logEncuesta();
        //privado para evitar la instanciación directa
        public static logEncuesta Instancia
        {
            get
            {
                return logEncuesta._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entEncuesta> ListarEncuesta()
        {
            return datEncuesta.Instancia.ListarEncuesta();
        }
        #endregion
    }
}
