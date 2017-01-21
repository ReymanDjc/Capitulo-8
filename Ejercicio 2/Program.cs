using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena: ");
            string caddena = Console.ReadLine();
            Console.WriteLine("Ingrese espacios para justificar: ");
            int espacio = int.Parse(Console.ReadLine());
            Console.WriteLine(caddena.PadLeft(espacio, ' '));
            Console.ReadKey();
        }
    }
}
