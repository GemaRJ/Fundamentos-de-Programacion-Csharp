using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Array unidimensional simple
        int[] numerosDatos = { 1, 5, 8 };
        Console.WriteLine("Array inicial: [" + string.Join(", ", numerosDatos) + "]");

        // Obtener el valor de una posición (desde 0)
        Console.WriteLine("Valor en la posición 0: " + numerosDatos[0]);

        // Obtener cuántos elementos tiene
        Console.WriteLine("Longitud del array: " + numerosDatos.Length);

        // Sacar el último número
        Console.WriteLine("Último elemento: " + numerosDatos[numerosDatos.Length - 1]);

        // Evaluar si el valor de una posición es igual a algo
        if (numerosDatos[1] == 5)
            Console.WriteLine("La posición 1 es igual a 5");

        // Asignar un valor a una posición
        numerosDatos[0] = 10;
        Console.WriteLine("Array tras asignar 10 en posición 0: [" + string.Join(", ", numerosDatos) + "]");

        // 2. Recorrer array con foreach
        Console.WriteLine("Recorriendo array con foreach:");
        foreach (int num in numerosDatos)
        {
            Console.WriteLine(num);
        }

        // 3. Array con valores aleatorios (sin repetir)
        int[] aleatorios = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < aleatorios.Length; i++)
        {
            int num;
            do
            {
                num = rnd.Next(1, 21); // 1 a 20
            } while (EstaNumero(num, aleatorios));
            aleatorios[i] = num;
        }
        Console.WriteLine("Array aleatorio sin repetir: [" + string.Join(", ", aleatorios) + "]");

        // 4. Array multidimensional
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Array multidimensional:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // 5. Números en posiciones pares
        Console.WriteLine("Elementos en posiciones pares:");
        for (int i = 0; i < aleatorios.Length; i += 2)
        {
            Console.WriteLine("Posición " + i + ": " + aleatorios[i]);
        }

        // 6. Ordenar array
        Array.Sort(aleatorios);
        Console.WriteLine("Array ordenado: [" + string.Join(", ", aleatorios) + "]");

        // 7. Mover elementos a la izquierda
        int[] izquierda = (int[])aleatorios.Clone();
        int primero = izquierda[0];
        for (int i = 0; i < izquierda.Length - 1; i++)
        {
            izquierda[i] = izquierda[i + 1];
        }
        izquierda[izquierda.Length - 1] = primero;
        Console.WriteLine("Array rotado a la izquierda: [" + string.Join(", ", izquierda) + "]");

        // 8. Mover elementos a la derecha
        int[] derecha = (int[])aleatorios.Clone();
        int ultimo = derecha[derecha.Length - 1];
        for (int i = derecha.Length - 1; i > 0; i--)
        {
            derecha[i] = derecha[i - 1];
        }
        derecha[0] = ultimo;
        Console.WriteLine("Array rotado a la derecha: [" + string.Join(", ", derecha) + "]");

        // 9. Invertir array
        int[] invertido = (int[])aleatorios.Clone();
        Array.Reverse(invertido);
        Console.WriteLine("Array invertido: [" + string.Join(", ", invertido) + "]");

        // 10. Array con posiciones pares usando foreach
        Console.WriteLine("Valores en posiciones pares usando foreach:");
        for (int i = 0; i < aleatorios.Length; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine("Posición " + i + ": " + aleatorios[i]);
        }
    }

    // Función auxiliar para comprobar si un número está en un array
    public static bool EstaNumero(int numero, int[] array)
    {
        foreach (int n in array)
        {
            if (n == numero)
                return true;
        }
        return false;
    }
}
