using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJEMPLOS DE FUNCIONES EN C# ===");

            // 1. MÉTODO SIN PARÁMETROS Y SIN RETORNO
            Saludar();

            // 2. MÉTODO CON PARÁMETROS PERO SIN RETORNO
            MostrarEdad(30);

            // 3. MÉTODO CON PARÁMETROS Y CON RETORNO
            int suma = Sumar(10, 20);
            Console.WriteLine("La suma es: " + suma);

            // 4. MÉTODO QUE DEVUELVE UN STRING
            string mensaje = CrearMensaje("Gema");
            Console.WriteLine(mensaje);

            // 5. MÉTODO QUE DEVUELVE UN BOOLEANO
            bool mayorEdad = EsMayor(18);
            Console.WriteLine("¿Es mayor de edad? " + mayorEdad);
        }

        // 1. Sin parámetros y sin retorno
        static void Saludar()
        {
            Console.WriteLine("Hola desde un método en C#.");
        }

        // 2. Con parámetros y sin retorno
        static void MostrarEdad(int edad)
        {
            Console.WriteLine("La edad es: " + edad);
        }

        // 3. Con parámetros y con retorno
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        // 4. Devuelve un string
        static string CrearMensaje(string nombre)
        {
            return $"Hola {nombre}, bienvenida al mundo C#.";
        }

        // 5. Devuelve un booleano
        static bool EsMayor(int edad)
        {
            return edad >= 18;
        }
    }
}
