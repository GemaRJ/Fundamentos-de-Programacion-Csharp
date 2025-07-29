using System;

class ProgramaTemperaturas
{
    static void Main()
    {
        int[] temperaturas = new int[7];
        string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        // Pedir temperaturas
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Introduce la temperatura del " + diasSemana[i] + ": ");
            while (!int.TryParse(Console.ReadLine(), out temperaturas[i]))
            {
                Console.Write("Entrada no válida. Introduce un número entero: ");
            }
        }

        GestorTemperaturas gestor = new GestorTemperaturas(temperaturas, diasSemana);

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Ver la temperatura media de la semana");
            Console.WriteLine("2. Mostrar el día más caluroso");
            Console.WriteLine("3. Mostrar el día más frío");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción (1-4): ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    double media = gestor.CalcularMedia();
                    Console.WriteLine("La temperatura media de la semana es: " + media.ToString("F2") + " grados.");
                    break;

                case "2":
                    string diaCaluroso = gestor.DiaMasCaluroso();
                    Console.WriteLine("El día más caluroso es " + diaCaluroso + ".");
                    break;

                case "3":
                    string diaFrio = gestor.DiaMasFrio();
                    Console.WriteLine("El día más frío es " + diaFrio + ".");
                    break;

                case "4":
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }
}

class GestorTemperaturas
{
    private int[] temperaturas;
    private string[] dias;

    public GestorTemperaturas(int[] temperaturas, string[] dias)
    {
        this.temperaturas = temperaturas;
        this.dias = dias;
    }

    public double CalcularMedia()
    {
        int suma = 0;
        foreach (int temp in temperaturas)
        {
            suma += temp;
        }
        return (double)suma / temperaturas.Length;
    }

    public string DiaMasCaluroso()
    {
        int max = temperaturas[0];
        int indice = 0;
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > max)
            {
                max = temperaturas[i];
                indice = i;
            }
        }
        return dias[indice] + " con " + max + " grados";
    }

    public string DiaMasFrio()
    {
        int min = temperaturas[0];
        int indice = 0;
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < min)
            {
                min = temperaturas[i];
                indice = i;
            }
        }
        return dias[indice] + " con " + min + " grados";
    }
}