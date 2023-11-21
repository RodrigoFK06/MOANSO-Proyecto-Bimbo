using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logPreguntasE
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPreguntasE _instancia = new logPreguntasE();
        //privado para evitar la instanciación directa
        public static logPreguntasE Instancia
        {
            get
            {
                return logPreguntasE._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entPreguntasE> ListarPreguntas()
        {
            return datPreguntasE.Instancia.ListarPreguntas();
        }
        ///Registrar
        public void RegistrarPreguntas(entPreguntasE pr)
        {
            datPreguntasE.Instancia.RegistrarPreguntas(pr);
        }

        ///Modificar
        public void ModificarPreguntas(entPreguntasE pr)
        {
            datPreguntasE.Instancia.ModificarPreguntas(pr);
        }

        #endregion
    }
}
