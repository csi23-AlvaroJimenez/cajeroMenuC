using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajeroMenuC.servicios
{
    /// <summary>
    /// Interfaz con la relacion de metodos de la funcionalidad menu
    /// 25 09 23 - jta
    /// 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra mensaje de bienvenida al cajero
        /// </summary>
        public void mostrarMensajeBienvenida();
        /// <summary>
        /// Metodo que muestra el menu y recoge la seleccion del usuario
        /// 26 09 2023 - jta
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();

    }

}