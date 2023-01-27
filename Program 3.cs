using System;

namespace Ejercicio_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición está el mayor primo leído.");

            int[] arreglo = new int[10];

            for(int z = 0; z < arreglo.Length ; z++){
                arreglo[z] = 0;
                Console.WriteLine("Digite el número para la posición {0} ",z);
                int.TryParse(Console.ReadLine(), out arreglo[z]);
            }

            int mayorPrimo = arreglo[0];
            int posicion = -1;

            for (int z = 0; z < arreglo.Length ; z++)
            {
                if (primo(arreglo[z]))
                {
                    if (arreglo[z] > mayorPrimo || !primo(mayorPrimo))
                    {
                        mayorPrimo = arreglo[z];
                        posicion = z;
                    }
                }
            }
            if (posicion == -1)
            {
                Console.WriteLine("No existen números primos en el arreglo");
            }
            else
            {
                Console.WriteLine($"El mayor número primo es {mayorPrimo}, en la posicion {posicion}");
            }

            static bool primo(int numero)
            {
                for(int z = 2; z < numero; z++)
                {
                    if ((numero % z) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
