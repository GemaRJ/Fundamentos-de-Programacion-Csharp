using System;
using Controller;

namespace Modularidad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos instancia de la clase Metodo
            Metodo metodos = new Metodo();

            // 1. Saludar
            metodos.MetodoSaludar();

            // 2. Divisiones
            double resultado1 = metodos.RealizarDivision();
            double resultado2 = metodos.RealizarDivision(6);
            double resultado3 = metodos.RealizarDivision(10, 5);
            double resultado4 = metodos.RealizarDivision(12.0, 4);
            double resultado5 = metodos.RealizarDivision(7, 2.0);

            Console.WriteLine("\nResultados de divisiones:");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
            Console.WriteLine(resultado5);

            // 3. Calcular media de un array
            int[] numeros = { 5, 10, 15, 20 };
            metodos.CalcularMedia(numeros);

            // 4. Sacar dinero
            Console.WriteLine("\nSimulación cajero:");
            metodos.SacarDinero(1234, 50);  // Pin correcto, saldo suficiente
            metodos.SacarDinero(1234, 200); // Pin correcto, saldo insuficiente
            metodos.SacarDinero(1111, 50);  // Pin incorrecto

            // 5. Mostrar la clase Metodo usando ToString
            Console.WriteLine("\nObjeto Metodo:");
            Console.WriteLine(metodos);
        }
    }
}
