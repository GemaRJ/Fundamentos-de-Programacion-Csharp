using System;

namespace VariablesEjemplo
{
    class Variables
    {
        static void Main(string[] args)
        {
            // VARIABLES EN C#
            // Una variable es un espacio en memoria donde guardamos datos.
            // C# es un lenguaje fuertemente tipado → siempre hay que indicar el tipo.

            // DECLARACIÓN Y ASIGNACIÓN
            int numero;     // Declaración
            numero = 10;    // Asignación

            int edad = 25;  // Declaración y asignación en la misma línea

            // TIPOS DE VARIABLES

            // Números enteros
            int cantidad = 100;           // Entero
            long poblacion = 8000000L;    // Entero largo (L opcional)

            // Números decimales
            float precio = 19.99f;        // Decimal simple (f obligatorio)
            double salario = 1850.75;     // Decimal doble precisión

            // Texto
            string nombre = "Gema";       // Texto
            char inicial = 'G';           // Un solo carácter

            // Booleanos
            bool esMayor = true;          // Verdadero
            bool activo = false;          // Falso

            // MOSTRAR VARIABLES POR CONSOLA
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Inicial: " + inicial);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("¿Es mayor?: " + esMayor);

            // Mostrar con formato (similar a printf)
            Console.WriteLine("La persona {0} tiene {1} años y gana {2:F2} €",
                nombre, edad, salario);

            // VARIABLES QUE CAMBIAN
            int contador = 1;
            contador = 2; // Se puede modificar el valor

            // CONSTANTES
            const double PI = 3.14159; // const = no se puede modificar
            Console.WriteLine("Valor de PI: " + PI);

            // DECLARACIÓN MÚLTIPLE
            int a = 1, b = 2, c = 3; // Se pueden declarar varias variables del mismo tipo en una línea

            // INICIALIZACIÓN TARDÍA
            string saludo;           // Se declara primero
            saludo = "Hola desde C#"; // Se asigna valor después
            Console.WriteLine(saludo);

            // COMPROBAR TIPOS DE DATOS
            Console.WriteLine(precio.GetType().Name);  // Single
            Console.WriteLine(activo.GetType().Name);  // Boolean
        }
    }
}
