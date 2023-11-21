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
    public class logEstandarCompetencia
    {

        #region singleton
        private static readonly logEstandarCompetencia _instancia = new logEstandarCompetencia();
        private datEstandarCompetencia dataAccess = datEstandarCompetencia.Instancia;
        public static logEstandarCompetencia Instancia
        {
            get { return logEstandarCompetencia._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entEstandarCompetencia> ListarEstandarCompetencia()
        {
            try
            {
                return datEstandarCompetencia.Instancia.ListarEstandarCompetencia();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool InsertarEstandarCompetencia(entEstandarCompetencia estandar)
        {
            try
            {
                datEstandarCompetencia.Instancia.InsertarEstandarCompetencia(estandar);
                return true;  // Si la inserción fue exitosa
            }
            catch (Exception ex)
            {
                // Puedes agregar algún registro de log o imprimir el mensaje de error si es necesario
                Console.WriteLine($"Error al insertar EstandarCompetencia: {ex.Message}");
                return false;  // Si ocurrió un error durante la inserción
            }
        }

        public bool EditarEstandarCompetencia(entEstandarCompetencia estandar)
        {
            try
            {
                return datEstandarCompetencia.Instancia.EditarEstandarCompetencia(estandar);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool EliminarEstandarCompetencia(int idEstandarCompetencia)
        {
            try
            {
                return datEstandarCompetencia.Instancia.EliminarEstandarCompetencia(idEstandarCompetencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable ObtenerIdArea()
        {
            return dataAccess.ObtenerIdArea();
        }

        public entEstandarCompetencia ObtenerEstandarCompetenciaPorId(int idEstandarCompetencia)
        {
            try
            {
                return datEstandarCompetencia.Instancia.ObtenerEstandarCompetenciaPorId(idEstandarCompetencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ObtenerSiguienteIdEstandarCompetencia()
        {
            try
            {
                return datEstandarCompetencia.Instancia.ObtenerSiguienteIdEstandarCompetencia();
            }
            catch (Exception e)
            {
                // Manejar la excepción según tus necesidades
                throw e;
            }
        }

        public int ObtenerNivelRequerido(int idEstandarCompetencia)
        {
            try
            {
                // Llamada al método de la capa de datos para obtener el NivelRequerido
                return datEstandarCompetencia.Instancia.ObtenerNivelRequerido(idEstandarCompetencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        #endregion metodos

    }
}
