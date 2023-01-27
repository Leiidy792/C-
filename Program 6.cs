using System;

namespace Ejercicio_6
{/// <summary>
 /// 11. Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números tienen, de
 ///   los almacenados allí, tienen mayor de 3 dígitos.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10] { 34, 23, 8, 10, 15, 66, 8, 9, 2, 3 };
            int posicion = 0;


            for (int i = 0; i < 10; i++)
            {
                if (miarreglo[i] > 100)
                {
                    posicion = i;
                    Console.WriteLine($"Existe un valor mayor de tres digitos en la posicion {posicion}");


                }

            }
        }
    }
}

