using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenas = "";

            Console.WriteLine("Ingrese palabra ");
            cadenas = Console.ReadLine();

            for (int i = 0; i <= cadenas.Length; i++)
            {
                try
                {
                    Console.WriteLine(cadenas[i]);

                }
                catch (Exception error)
                {

                }
            }
            Console.ReadKey();
        }
    }
}
