using System;

namespace Ejercicio_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición está el mayor par leído.");

            int[] arreglo = new int[10];

            for(int z = 0; z < arreglo.Length ; z++){
                arreglo[z] = 0;
                Console.WriteLine("Digite el número para la posición {0} ",z);
                int.TryParse(Console.ReadLine(), out arreglo[z]);
            }

            int mayorPar = 0;
            int posicion = 0;

            for (int z = 0; z < arreglo.Length ; z++)
            {
                if (arreglo[z] % 2 == 0)
                {
                    if (arreglo[z] > mayorPar || mayorPar%2 == 1){
                        mayorPar = arreglo[z];
                        posicion = z;
                    }
                }
            }
            Console.WriteLine($"El valor mayor par es: {mayorPar}, en la posicion {posicion}");
        }
    }
}

