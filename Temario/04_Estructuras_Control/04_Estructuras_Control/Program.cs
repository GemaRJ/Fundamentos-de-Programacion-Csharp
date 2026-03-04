using System;

public class EstructurasControl
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== ESTRUCTURAS DE CONTROL EN C# ===\n");

        // 1. IF SIMPLE
        int numero = 10;
        if (numero > 5)
        {
            Console.WriteLine("El número es mayor que 5");
        }

        // 2. IF-ELSE
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }

        // 3. IF-ELSE IF-ELSE
        if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else if (numero == 0)
        {
            Console.WriteLine("El número es cero");
        }
        else
        {
            Console.WriteLine("El número es positivo");
        }

        // 4. SWITCH-CASE
        int dia = 3;
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            default:
                Console.WriteLine("Otro día");
                break;
        }

        // 5. FOR
        Console.WriteLine("\nBucle FOR:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // 6. WHILE
        Console.WriteLine("\nBucle WHILE:");
        int contador = 0;
        while (contador < 5)
        {
            Console.WriteLine("contador = " + contador);
            contador++;
        }

        // 7. DO-WHILE
        Console.WriteLine("\nBucle DO-WHILE:");
        int n = 0;
        do
        {
            Console.WriteLine("n = " + n);
            n++;
        } while (n < 5);

        // 8. FOREACH (ideal para arrays o listas)
        Console.WriteLine("\nBucle FOREACH:");
        int[] numeros = { 10, 20, 30, 40, 50 };
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        // 9. BREAK y CONTINUE
        Console.WriteLine("\nUso de BREAK y CONTINUE:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Se detiene el bucle en i = 5");
                break; // sale del bucle
            }
            if (i % 2 == 0)
            {
                continue; // salta a la siguiente iteración
            }
            Console.WriteLine("i impar = " + i);
        }
    }
}

