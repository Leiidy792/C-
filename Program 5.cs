using System;

namespace Ejercicio_arreglo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores del arreglo.
            Console.Clear();
            Console.WriteLine("Digite 10 numeros");

            int[] arreglo = new int[10];

            for(int z = 0; z < arreglo.Length ; z++){
                arreglo[z] = 0;
                Console.WriteLine("Digite el número para la posición {0} ",z);
                int.TryParse(Console.ReadLine(), out arreglo[z]);
            }

            Console.WriteLine("Digite el número entero con el que se realizará la operación: ");
            int dividendo = Convert.ToInt32(Console.ReadLine());

            int divisores = 0;

            foreach(int i in arreglo){
                if(dividendo / i == 1){
                    divisores = divisores + 1;
                }
            }
            Console.WriteLine($"Existen {divisores} divisores exactos en este arreglo para el valor ingresado");
        }
    }
}

