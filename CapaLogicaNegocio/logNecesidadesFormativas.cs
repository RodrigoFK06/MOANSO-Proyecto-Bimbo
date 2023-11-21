using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logNecesidadesFormativas
    {
        #region singleton
        private static readonly logNecesidadesFormativas _instancia = new logNecesidadesFormativas();
        private datNecesidadesFormativas dataAccess = datNecesidadesFormativas.Instancia;
        public static logNecesidadesFormativas Instancia
        {
            get { return logNecesidadesFormativas._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entNecesidadesFormativas> ListarNecesidadesFormativas()
        {
            try
            {
                return datNecesidadesFormativas.Instancia.ListarNecesidadesFormativas();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool InsertarNecesidadesFormativas(entNecesidadesFormativas necesidad)
        {
            try
            {
                return datNecesidadesFormativas.Instancia.InsertarNecesidadesFormativas(necesidad);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public DataTable ObtenerIdEstandarCompetencia()
        {
            return dataAccess.ObtenerIdEstandarCompetencia();
        }

        public DataTable ObtenerIdResolucionEvaluacionDesempeno()
        {
            return dataAccess.ObtenerIdResolucionEvaluacionDesempeno();
        }

        public int ObtenerSiguienteIdNecesidadesFormativas()
        {
            return dataAccess.ObtenerSiguienteIdNecesidadesFormativas();
        }

        public bool EliminarNecesidadesFormativas(int idNecesidadesFormativas)
        {
            try
            {
                return datNecesidadesFormativas.Instancia.EliminarNecesidadesFormativas(idNecesidadesFormativas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public entNecesidadesFormativas ObtenerNecesidadFormativaPorId(int idNecesidadesFormativas)
        {
            try
            {
                return dataAccess.ObtenerNecesidadFormativaPorId(idNecesidadesFormativas);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ObtenerNotaTotal(int idResolucionEvaluacionDesempeno)
        {
            try
            {
                // Llamada al método de la capa de datos para obtener la NotaTotal
                return datNecesidadesFormativas.Instancia.ObtenerNotaTotal(idResolucionEvaluacionDesempeno);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        #endregion metodos
    }
}
