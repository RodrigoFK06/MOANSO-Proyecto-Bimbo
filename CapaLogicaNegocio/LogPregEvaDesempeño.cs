using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class LogPregEvaDesempeño
    {
        #region singleton
        private static readonly LogPregEvaDesempeño _instancia = new LogPregEvaDesempeño();
        public static LogPregEvaDesempeño Instancia
        {
            get { return LogPregEvaDesempeño._instancia; }
        }
        #endregion singleton

        #region metodos

        public List<entPregEvaDesempeño> ListarPregEvaDesempeño()
        {
            try
            {
                return PregEvaDesempeñoDatos.Instancia.ListarPregEvaDesempeño();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            try
            {
                PregEvaDesempeñoDatos.Instancia.InsertarPregEvaDesempeño(preg);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void EliminarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            PregEvaDesempeñoDatos.Instancia.EliminarPregEvaDesempeño(preg);
        }
        public Boolean EditarPregEvaDesempeño(entPregEvaDesempeño preg)
        {
            try
            {
                return PregEvaDesempeñoDatos.Instancia.EditarPregEvaDesempeño(preg);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
