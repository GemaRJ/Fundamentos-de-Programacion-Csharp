class Calculadora
{
    static void Main()
    {
        int numero1, numero2, opcion;
        // Pedir los números una sola vez al principio
        Console.Write("Introduce el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Entrada inválida. Intenta de nuevo: ");
        }
        Console.Write("Introduce el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Entrada inválida. Intenta de nuevo: ");
        }
        // Bucle del menú
        do
        {
            Console.WriteLine("\n--- CALCULADORA ---");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Módulo");
            Console.WriteLine("6. Pares e impares");
            Console.WriteLine("7. Mayor y menor");
            Console.WriteLine("8. 20% de la suma");
            Console.WriteLine("9. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Suma: " + (numero1 + numero2));
                    break;

                case 2:
                    Console.WriteLine("Resta: " + (numero1 - numero2));
                    break;

                case 3:
                    Console.WriteLine("Multiplicación: " + (numero1 * numero2));
                    break;

                case 4:
                    if (numero2 == 0)
                        Console.WriteLine("No se puede dividir por cero.");
                    else
                        Console.WriteLine("División: " + ((double)numero1 / numero2));
                    break;

                case 5:
                    Console.WriteLine("Módulo: " + (numero1 % numero2));
                    break;

                case 6:
                    Console.WriteLine("Número 1 es " + (numero1 % 2 == 0 ? "par" : "impar"));
                    Console.WriteLine("Número 2 es " + (numero2 % 2 == 0 ? "par" : "impar"));
                    break;

                case 7:
                    Console.WriteLine("Mayor: " + Math.Max(numero1, numero2));
                    Console.WriteLine("Menor: " + Math.Min(numero1, numero2));
                    break;

                case 8:
                    double porcentaje = (numero1 + numero2) * 0.2;
                    Console.WriteLine("20% de la suma: " + porcentaje);
                    break;

                case 9:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 9);
    }
}
