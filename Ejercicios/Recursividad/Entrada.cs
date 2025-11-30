using System;

namespace Ejercicios
{
    class Entrada
    {
        static void Main(string[] args)
        {
            Ejercicio1Logica logica = new Ejercicio1Logica();

            Console.WriteLine("Introduce un número:");
            int a = int.Parse(Console.ReadLine() ?? "0"); // Evita posible valor nulo

            Console.WriteLine("Introduce otro número:");
            int b = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("La suma es: " + logica.Sumar(a, b));

            Console.WriteLine("¿Qué número quieres comprobar si es primo?");
            int n = int.Parse(Console.ReadLine() ?? "0");

            if (logica.EsPrimo(n))
            {
                Console.WriteLine(n + " SÍ es primo.");
            }
            else
            {
                Console.WriteLine(n + " NO es primo.");
            }
        }
    }
}
