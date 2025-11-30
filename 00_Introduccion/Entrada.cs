// Nombre del archivo debe coincidir con la clase pública

using System;

namespace Introduccion
{
    class Entrada
    {
        static void Main(string[] args)
        {
            /*
             * INTRODUCCIÓN A C#:
             * C# es un lenguaje de programación de propósito general, orientado a objetos,
             * tipado fuerte y desarrollado por Microsoft. Al igual que Java, cada variable
             * debe declarar su tipo y no puede cambiarlo durante la ejecución.
             *
             * Características principales:
             * - Orientación a objetos
             * - Tipado fuerte y estático
             * - Multiplataforma con .NET Core / .NET 5+
             * - Gestión automática de memoria con Garbage Collector
             */

            // EJEMPLO DE VARIABLES

            // Tipos de datos básicos
            string texto = "Soy un dato tipo String";
            int numero = 5;
            double decimalNum = 1.5;
            bool verdadero = true;

            // Mostrar tipo de dato
            Console.WriteLine(texto.GetType().Name); // String
            Console.WriteLine(numero.GetType().Name); // Int32
            Console.WriteLine(decimalNum.GetType().Name); // Double
            Console.WriteLine(verdadero.GetType().Name); // Boolean

            // Salida con formato
            string nombre = "GEMA";
            string correo = "GEMA@gmail.com";
            Console.WriteLine("El correo de {0} es {1}, el cual cuenta con {2} caracteres",
                nombre, correo, correo.Length);

            // Pedir datos por consola
            Console.Write("¿Cuál es tu nombre? ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("¿Cuál es tu correo? ");
            string correoUsuario = Console.ReadLine();

            Console.Write("¿Cuál es tu edad? ");
            int edadUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre ingresado: " + nombreUsuario);
            Console.WriteLine("Correo ingresado: " + correoUsuario);
            Console.WriteLine("Edad ingresada: " + edadUsuario);
        }
    }
}
