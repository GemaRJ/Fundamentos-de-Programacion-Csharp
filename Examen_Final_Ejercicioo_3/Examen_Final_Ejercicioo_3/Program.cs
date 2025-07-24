class Program
{
    static void Main(string[] args)
    {
        Entrada entrada = new Entrada();
        entrada.CrearEntradas();

        Console.WriteLine("Pulsa cualquier tecla para salir...");
        Console.ReadKey();
    }
}