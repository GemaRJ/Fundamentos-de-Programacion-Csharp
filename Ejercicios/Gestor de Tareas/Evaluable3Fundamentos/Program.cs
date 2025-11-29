using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡¡¡ Bienvenido a la última Evaluable del Curso DAW !!!");
        GestorTareas gestor = new GestorTareas();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Crear tarea");
            Console.WriteLine("2. Buscar tareas por tipo");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Exportar tareas");
            Console.WriteLine("5. Importar tareas");
            Console.WriteLine("6. Ver todas las tareas");
            Console.WriteLine("7. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": gestor.CrearTarea(); break;
                case "2": gestor.BuscarPorTipo(); break;
                case "3": gestor.EliminarTarea(); break;
                case "4": gestor.Exportar(); break;
                case "5": gestor.Importar(); break;
                case "6": gestor.MostrarTareas(); break;
                case "7": salir = true; break;
                default: Console.WriteLine("Opción no correcta."); break;
            }
        }

        Console.WriteLine("Saliendo del Programa...");
    }
}
