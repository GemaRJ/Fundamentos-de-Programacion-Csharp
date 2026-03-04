using System;

namespace Ejercicios
{
    class Ejercicio2
    {
        static void Main()
        {
            /*
             * Enunciado:
             * Generar 30 números aleatorios entre 0 y 10,
             * almacenarlos en un array y calcular el sumatorio y la media.
             */

            int[] numerosGenerados = new int[30];
            int sumatorio = 0;
            Random rnd = new Random();

            for (int i = 0; i < numerosGenerados.Length; i++)
            {
                numerosGenerados[i] = rnd.Next(0, 11);
                sumatorio += numerosGenerados[i];
            }

            double media = (double)sumatorio / numerosGenerados.Length;
            Console.WriteLine("Sumatorio: " + sumatorio);
            Console.WriteLine("Media: " + media);
        }
    }
}
