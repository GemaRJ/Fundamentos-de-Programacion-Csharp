using System;

namespace Ejercicios
{
    class Ejercicio6
    {
        static void Main()
        {
            /*
             * Enunciado:
             * Crear un array de 10 palabras. Ofrecer un menú para:
             * 1. Rellenar palabras manualmente
             * 2. Mostrar una palabra aleatoria
             * 3. Contar total de letras
             * 4. Calcular media de letras por palabra
             * 5. Mostrar la palabra más grande
             * 6. Mostrar la palabra más pequeña
             * 7. Salir
             */

            string[] palabras = new string[10];
            int opcion = 0;
            Random rnd = new Random();

            do
            {
                Console.WriteLine("\nMenu de palabras:");
                Console.WriteLine("1. Rellenar palabras");
                Console.WriteLine("2. Mostrar palabra aleatoria");
                Console.WriteLine("3. Total de letras");
                Console.WriteLine("4. Media de letras");
                Console.WriteLine("5. Palabra más grande");
                Console.WriteLine("6. Palabra más pequeña");
                Console.WriteLine("7. Salir");
                Console.Write("Introduce opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < palabras.Length; i++)
                        {
                            Console.Write("Introduce palabra: ");
                            palabras[i] = Console.ReadLine();
                        }
                        break;

                    case 2:
                        int posAleatoria = rnd.Next(0, palabras.Length);
                        Console.WriteLine("Palabra aleatoria: " + palabras[posAleatoria]);
                        break;

                    case 3:
                        int totalLetras = 0;
                        foreach (string palabra in palabras)
                            if (palabra != null) totalLetras += palabra.Length;
                        Console.WriteLine("Total de letras: " + totalLetras);
                        break;

                    case 4:
                        int sumaLetras = 0;
                        int contador = 0;
                        foreach (string palabra in palabras)
                            if (palabra != null) { sumaLetras += palabra.Length; contador++; }
                        if (contador == 0) Console.WriteLine("No se han introducido palabras");
                        else Console.WriteLine("Media de letras: " + (double)sumaLetras / contador);
                        break;

                    case 5:
                        string palabraGrande = palabras[0];
                        foreach (string palabra in palabras)
                            if (palabra != null && palabra.Length > palabraGrande.Length) palabraGrande = palabra;
                        Console.WriteLine("Palabra más grande: " + palabraGrande);
                        break;

                    case 6:
                        string palabraPequenia = palabras[0];
                        foreach (string palabra in palabras)
                            if (palabra != null && palabra.Length < palabraPequenia.Length) palabraPequenia = palabra;
                        Console.WriteLine("Palabra más pequeña: " + palabraPequenia);
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opcion != 7);
        }
    }
}
