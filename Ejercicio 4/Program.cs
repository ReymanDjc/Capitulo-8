using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num + num2;
            if (suma < 0){
                Console.WriteLine("Suma es " + "(" + suma + ")");
            }
            else{
                Console.WriteLine("Suma es " + suma);
            }
            Console.ReadKey();
        }
    }
}
