namespace Calculador.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 171023 - dmp
    /// </summary>
    class program
    {
        /// <summary>
        /// Lleva a cabo las acciones
        /// 171023 - dmp
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            menu.mostrarMensajeBienvenida();
            
            // Controla la entrada y salida del bucle
                bool cerrarMenu = false;
            // declaro un entero
                int opcionIntroducida;

                while(!cerrarMenu)
                {
                    opcionIntroducida = menu.mostrarMenuYSeleccion();
                    switch(opcionIntroducida)
                    {
                        //suma
                        case 0:
                        Console.WriteLine("Elija el primer operando");
                        int operandoUno = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el segundo operando");
                        int operandoDos = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(operandoUno + operandoDos);
                            break;
                        //resta
                        case 1:
                        Console.WriteLine("Elija el primer operando");
                        int operandoTres = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el segundo operando");
                        int operandoCuatro = Int32.Parse(Console.ReadLine());
                            Console.WriteLine( operandoTres - operandoCuatro);
                            break;
                        //multiplicación
                        case 2:
                        Console.WriteLine("Elija el primer operando");
                        int operandoCinco = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el segundo operando");
                        int operandoSeis = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(operandoCinco * operandoSeis);
                            break;
                        //division
                        case 3:
                        Console.WriteLine("Elija el primer operando");
                            int operandoSiete = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el segundo operando");
                            int operandoOcho = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(operandoSiete / operandoOcho );
                            break;

                        default:

                            Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                            break;
                    }
                }
            
        }
    }
}
