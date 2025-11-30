using System;

public class Operadores
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== OPERADORES ARITMÉTICOS ===");
        int a = 10;
        int b = 3;

        // Suma
        Console.WriteLine("a + b = " + (a + b)); // 10 + 3 = 13

        // Resta
        Console.WriteLine("a - b = " + (a - b)); // 10 - 3 = 7

        // Multiplicación
        Console.WriteLine("a * b = " + (a * b)); // 10 * 3 = 30

        // División
        Console.WriteLine("a / b = " + (a / b)); // 10 / 3 = 3 (división entera)

        // División con decimales
        Console.WriteLine("a / (double)b = " + (a / (double)b)); // 10 / 3.0 = 3.3333

        // Módulo (resto de la división)
        Console.WriteLine("a % b = " + (a % b)); // 10 % 3 = 1

        Console.WriteLine("\n=== OPERADORES RELACIONALES ===");
        // Comparan valores y devuelven true o false
        Console.WriteLine("10 == 3? " + (a == b)); // false, 10 no es igual a 3
        Console.WriteLine("10 != 3? " + (a != b)); // true, 10 es distinto de 3
        Console.WriteLine("10 > 3? " + (a > b));   // true, 10 es mayor que 3
        Console.WriteLine("10 < 3? " + (a < b));   // false, 10 no es menor que 3
        Console.WriteLine("10 >= 3? " + (a >= b)); // true, 10 es mayor o igual a 3
        Console.WriteLine("10 <= 3? " + (a <= b)); // false, 10 no es menor ni igual a 3

        Console.WriteLine("\n=== OPERADORES LÓGICOS ===");
        bool verdadero = true;
        bool falso = false;

        // AND lógico
        Console.WriteLine("true && false = " + (verdadero && falso)); // false

        // OR lógico
        Console.WriteLine("true || false = " + (verdadero || falso)); // true

        // NOT lógico
        Console.WriteLine("!true = " + (!verdadero)); // false

        Console.WriteLine("\n=== OPERADORES DE INCREMENTO/DECREMENTO ===");
        int c = 5;

        // Incremento
        Console.WriteLine("c = " + c);   // 5
        Console.WriteLine("c++ = " + c++); // Muestra 5, luego c=6
        Console.WriteLine("++c = " + ++c); // c=7, luego muestra 7

        // Decremento
        Console.WriteLine("c-- = " + c--); // Muestra 7, luego c=6
        Console.WriteLine("--c = " + --c); // c=5, luego muestra 5

        Console.WriteLine("\n=== OPERADORES DE ASIGNACIÓN ===");
        int d = 10;

        d += 5; // d = d + 5
        Console.WriteLine("d += 5 -> " + d); // 15

        d -= 3; // d = d - 3
        Console.WriteLine("d -= 3 -> " + d); // 12

        d *= 2; // d = d * 2
        Console.WriteLine("d *= 2 -> " + d); // 24

        d /= 4; // d = d / 4
        Console.WriteLine("d /= 4 -> " + d); // 6

        d %= 5; // d = d % 5
        Console.WriteLine("d %= 5 -> " + d); // 1

        Console.WriteLine("\n=== OPERADOR TERNARIO ===");
        int edad = 20;
        string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
        Console.WriteLine("Edad: " + edad + " -> " + mensaje);
    }
}
