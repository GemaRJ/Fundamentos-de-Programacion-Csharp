public class Entrada
{
  
    public void CrearEntradas()
    {
        GestorDiario gestor = new GestorDiario();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Entrada número " + i);

            Console.Write("Introduce el título: ");
            string titulo = Console.ReadLine();

            Console.Write("Introduce el contenido: ");
            string contenido = Console.ReadLine();

            EntradaDiario entrada = new EntradaDiario()
            {
                Fecha = DateTime.Now,
                Titulo = titulo,
                Contenido = contenido
            };

            gestor.GuardarEntrada(entrada);
            Console.WriteLine("Entrada guardada correctamente.\n");
        }

        gestor.MostrarDiario();
    }
}