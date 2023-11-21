using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logAreas
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAreas _instancia = new logAreas();
        //privado para evitar la instanciación directa
        public static logAreas Instancia
        {
            get
            {
                return logAreas._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entAreas> ListarAreas()
        {
            return datAreas.Instancia.ListarAreas();
        }
        ///Registrar
        public void RegistrarArea(entAreas ar)
        {
            datAreas.Instancia.RegistrarArea(ar);
        }

        ///Modificar
        public void ModificarArea(entAreas ar)
        {
            datAreas.Instancia.ModificarArea(ar);
        }

        #endregion
    }
}
