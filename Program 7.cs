using System;

namespace Ejercicio_7
{/// <summary>
 /// 12. Leer 10 números enteros, almacenarlos  y determinar a cuánto es igual el promedio entero de los datos.

/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10] { 34, 54, 8, 0, 36, 16, 28, 19, 2, 3 };
            int sumaTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                sumaTotal = sumaTotal + arreglo[i];
            }

            int promedio = sumaTotal / 10;

            Console.WriteLine($"El promedio de los elementos es {promedio}");
        }
    }
    }
