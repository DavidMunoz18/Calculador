using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Calculadora"; 
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0. Se realiza la suma");
            Console.WriteLine("1. Se realiza la resta");
            Console.WriteLine("2. Se realiza la multiplicacion");
            Console.WriteLine("3. Se realiza la division");
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            return opcionIntroducida;
        }
    }
}
