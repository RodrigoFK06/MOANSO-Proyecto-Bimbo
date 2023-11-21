using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class LogDetEvaDesempeño
    {
        #region singleton
        private static readonly LogDetEvaDesempeño _instancia = new LogDetEvaDesempeño();
        public static LogDetEvaDesempeño Instancia
        {
            get { return LogDetEvaDesempeño._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entDetEvaDesempeño> ListarDetEvaDesempeño()
        {
            try
            {
                return DetEvaDesempeñoDatos.Instancia.ListarDetEvaDesempeño();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertarDetEvaDesempeño(entDetEvaDesempeño det)
        {
            try
            {
                DetEvaDesempeñoDatos.Instancia.InsertarDetEvaDesempeño(det);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Boolean EditarDetEvaDesempeño(entDetEvaDesempeño det)
        {
            try
            {
                return DetEvaDesempeñoDatos.Instancia.EditarDetEvaDesempeño(det);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion metodos
    }
}
