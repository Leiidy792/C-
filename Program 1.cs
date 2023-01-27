using System;

namespace Ejercicio_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición está el mayor leído.");

            int[] arreglo = new int[10];

            for(int z = 0; z < arregl.Length ; z++){
                arreglo[z] = 0;
                Console.WriteLine("Digite el número para la posición {0} ",z);
                int.TryParse(Console.ReadLine(), out arreglo[z]);
            }

            int mayor = 0;
            int posicion = 0;

            for (int z = 0; z < arreglo.Length ; z++)
            {
                if (arregl[z] > mayor)
                {
                    mayor = arreglo[z];
                    posicion = z;
                }
            }
            Console.WriteLine($"El valor mayor es: {mayor}, en la posicion {posicion}");
        }
    }
}
