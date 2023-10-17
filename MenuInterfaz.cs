using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    /// <summary>
    /// Contiene las cabeceras de los metodos
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje de bienvenida
        /// </summary>
        void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu y recoge las opciones
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
