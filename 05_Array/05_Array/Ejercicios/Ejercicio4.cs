using System;

class Ejercicio4
{
    static void Main()
    {
        int[] numeros = new int[8];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Introduce un número: ");
            string input = Console.ReadLine(); // Puede devolver null
            // Convertimos a entero usando TryParse para evitar error por posible valor nulo
            if (!int.TryParse(input, out numeros[i]))
            {
                Console.WriteLine("Entrada no válida o valor nulo. Se usará 0.");
                numeros[i] = 0;
            }
        }

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                Console.WriteLine("Par: " + num);
            else
                Console.WriteLine("Impar: " + num);
        }
    }
}

