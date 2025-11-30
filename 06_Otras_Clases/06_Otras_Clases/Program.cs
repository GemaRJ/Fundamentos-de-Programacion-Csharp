using System;

class Program
{
    static void Main()
    {
        // 1. Date / Fecha actual
        DateTime fechaActual = DateTime.Now;
        Console.WriteLine("Fecha y hora actual: " + fechaActual);

        // Formatear fecha
        Console.WriteLine("Fecha formateada: " + fechaActual.ToString("dd/MM/yyyy HH:mm:ss"));

        // 2. Random / números aleatorios
        Random rnd = new Random();
        int numAleatorio = rnd.Next(1, 101); // 1-100
        Console.WriteLine("Número aleatorio entre 1 y 100: " + numAleatorio);

        // 3. Math / operaciones matemáticas
        double valor = -5.7;
        Console.WriteLine("Valor absoluto: " + Math.Abs(valor));
        Console.WriteLine("Redondeo: " + Math.Round(valor));
        Console.WriteLine("Potencia 2^3: " + Math.Pow(2, 3));
        Console.WriteLine("Raíz cuadrada de 25: " + Math.Sqrt(25));

        // 4. Scanner / Leer datos del usuario
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine(); // equivalente a Scanner.nextLine()
        Console.Write("Introduce tu edad: ");
        int edad;
        // Convertir a int, permitiendo posible valor nulo
        edad = int.TryParse(Console.ReadLine(), out int resultadoEdad) ? resultadoEdad : 0;

        Console.WriteLine($"Hola {nombre}, tienes {edad} años.");

        // 5. String / cadenas
        string texto = "Hola Mundo";
        Console.WriteLine("Longitud del texto: " + texto.Length);
        Console.WriteLine("Mayúsculas: " + texto.ToUpper());
        Console.WriteLine("Minúsculas: " + texto.ToLower());
        Console.WriteLine("Contiene 'Mundo'? " + texto.Contains("Mundo"));

        // 6. Tipos envoltorio / conversiones
        int numeroInt = 42;
        double numeroDouble = 3.1416;
        string textoNumero = numeroInt.ToString(); // int a string
        int desdeTexto = int.Parse("123");         // string a int
        bool conversionExitosa = int.TryParse("456", out int numConvertido); // safer conversion

        Console.WriteLine($"Int a string: {textoNumero}, String a int: {desdeTexto}, TryParse: {numConvertido}");
    }
}
