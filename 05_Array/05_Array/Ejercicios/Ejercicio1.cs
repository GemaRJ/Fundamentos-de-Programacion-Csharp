using System;

namespace Ejercicios
{
    class Ejercicio1
    {
        static void Main()
        {
            /*
             * Enunciado:
             * Crear un array unidimensional con valores iniciales, 
             * acceder a sus elementos, modificar valores y recorrer el array.
             */

            int[] numerosDatos = { 1, 5, 8 };
            Console.WriteLine("Array inicial: [" + string.Join(", ", numerosDatos) + "]");

            Console.WriteLine("Valor en posición 0: " + numerosDatos[0]);
            Console.WriteLine("Longitud del array: " + numerosDatos.Length);
            Console.WriteLine("Último elemento: " + numerosDatos[numerosDatos.Length - 1]);

            if (numerosDatos[1] == 5)
            {
                Console.WriteLine("La posición 1 es igual a 5");
            }

            numerosDatos[0] = 10;
            Console.WriteLine("Array tras asignar 10 en posición 0: [" + string.Join(", ", numerosDatos) + "]");

            Console.WriteLine("Recorriendo array con foreach:");
            foreach (int num in numerosDatos) Console.WriteLine(num);
        }
    }
}
