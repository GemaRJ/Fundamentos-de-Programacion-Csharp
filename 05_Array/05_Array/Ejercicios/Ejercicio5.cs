using System;

namespace Ejercicios
{
    class Ejercicio5
    {
        static void Main()
        {
            /*
             * Enunciado:
             * Generar un array de 20 números aleatorios entre 0 y 30.
             * Sustituir todos los 6 por 8, los 7 por 15 y los 20 por 10.
             * Mostrar el array antes y después de los cambios y el número de cambios realizados.
             */

            int[] numeros = new int[20];
            int cambios = 0;
            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
                numeros[i] = rnd.Next(0, 31);

            Console.WriteLine("Array original: [" + string.Join(", ", numeros) + "]");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 6) { numeros[i] = 8; cambios++; }
                if (numeros[i] == 7) { numeros[i] = 15; cambios++; }
                if (numeros[i] == 20) { numeros[i] = 10; cambios++; }
            }

            Console.WriteLine("Array modificado: [" + string.Join(", ", numeros) + "]");
            Console.WriteLine("Número de cambios realizados: " + cambios);
        }
    }
}
