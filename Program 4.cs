using System;
using System.Linq;

namespace Ejercicio_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo.
            Console.Clear();
            Console.WriteLine("Digite 10 numeros");

            int[] arreglo = new int[10];

            for(int z = 0; z < arreglo.Length ; z++){
                arreglo[z] = 0;
                Console.WriteLine("Digite el número para la posición {0} ",z);
                int.TryParse(Console.ReadLine(), out arreglo[z]);
            }

            float promedio = arreglo.Sum() / 10;

            Console.WriteLine($"El promedio entero de los datos del arreglo es: {promedio}");
        }
    }
}

