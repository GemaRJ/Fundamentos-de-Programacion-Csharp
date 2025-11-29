using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double operador1, operador2;
            while (true)
            {
                Console.WriteLine("¡Mi Primera Calculadora!");
                Console.WriteLine("========================");
                Console.WriteLine("Introduzca el primer número");
                operador1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo número");
                operador2 = Convert.ToDouble(Console.ReadLine());
                if (operador1 >= 0 && operador2 >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Deben de ser positivos");
                }
            }

            while (true)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                
                if (opcion == 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    break;
                }

                double result = 0;
                switch (opcion)
                {
                    case 1:
                        result = operador1 + operador2;
                        Console.WriteLine("Resultado: " + operador1 + " + " + operador2 + " = " + result);
                        break;
                    case 2:
                        result = operador1 - operador2;
                        Console.WriteLine("Resultado: " + operador1 + " - " + operador2 + " = " + result);
                        break;
                    case 3:
                        result = operador1 * operador2;
                        Console.WriteLine("Resultado: " + operador1 + " x " + operador2 + " = " + result);
                        break;
                    case 4:
                        if (operador2 == 0)
                        {
                            Console.WriteLine("Error: División por cero no permitida.");
                        }
                        else
                        {
                            result = operador1 / operador2;
                            Console.WriteLine("Resultado: " + operador1 + " / " + operador2 + " = " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no se encuentra dentro de las opciones seleccionadas.");
                        break;
                }
            }
        }
    }
}