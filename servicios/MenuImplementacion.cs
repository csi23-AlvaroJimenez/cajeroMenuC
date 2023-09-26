using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajeroMenuC.servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de menu
    /// 25 09 23 - jta
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            String mensaje = "Banco Cs1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("############################");
            Console.WriteLine("0. Cierra Aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar Dinero");
            Console.WriteLine("3. Sacar Dinero");
            Console.WriteLine("4. Transferir Dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("############################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;
        }
    }
}
