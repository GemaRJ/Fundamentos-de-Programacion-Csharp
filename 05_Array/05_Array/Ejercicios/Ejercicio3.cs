using System;

namespace Ejercicios
{
    class Ejercicio3
    {
        static void Main()
        {
            /*
             * Enunciado:
             * Generar 20 números aleatorios entre 0 y 100,
             * calcular su cuadrado y cubo y mostrarlos en formato tabla.
             */

            int[] numeros = new int[20];
            int[] cuadrados = new int[20];
            int[] cubos = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(0, 101);
                cuadrados[i] = numeros[i] * numeros[i];
                cubos[i] = numeros[i] * numeros[i] * numeros[i];
            }

            Console.WriteLine("Posición | Número | Cuadrado | Cubo");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{i,8} | {numeros[i],6} | {cuadrados[i],8} | {cubos[i],4}");
            }
        }
    }
}
