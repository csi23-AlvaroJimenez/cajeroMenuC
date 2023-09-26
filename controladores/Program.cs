using cajeroMenuC.servicios;

namespace cajeroMenuC.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 25 09 23 - jta
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 25 09 23 - jta
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args) 
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mostrarMensajeBienvenida();
            //variable que controla la entrada y salida del bucle
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSeleccionada;
            //desde la primera iteración debe cumplirse la condición 
            while (!cerrarMenu) 
            {
                opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0.");
                        cerrarMenu |= true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1.");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2.");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3.");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4.");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5.");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}