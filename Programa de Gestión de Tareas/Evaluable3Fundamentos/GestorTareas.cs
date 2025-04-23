using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GestorTareas
{
    private List<Tarea> tareas = new List<Tarea>();

    public void CrearTarea()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Descripción: ");
        string descripcion = Console.ReadLine();

        Console.Write("Tipo (Personal, Trabajo, Ocio): ");
        TipoTarea tipo;
        while (!Enum.TryParse(Console.ReadLine(), true, out tipo))
        {
            Console.Write("Tipo incorrecto. Escribe Personal, Trabajo u Ocio: ");
        }

        Console.Write("¿Es prioridad alta? (s/n): ");
        bool prioridad = Console.ReadLine().ToLower() == "s";

        var tarea = new Tarea(nombre, descripcion, tipo, prioridad);
        tareas.Add(tarea);
        Console.WriteLine("Tarea creada.");
    }

    public void BuscarPorTipo()
    {
        Console.Write("Tipo a buscar (Personal, Trabajo, Ocio): ");
        TipoTarea tipo;
        while (!Enum.TryParse(Console.ReadLine(), true, out tipo))
        {
            Console.Write("Tipo incorrecto. Escribe Personal, Trabajo u Ocio: ");
        }

        var resultado = tareas.Where(t => t.Tipo == tipo).ToList();

        if (resultado.Count == 0)
            Console.WriteLine("No hay tareas de ese tipo.");
        else
            resultado.ForEach(t => Console.WriteLine(t));
    }

    public void EliminarTarea()
    {
        Console.Write("ID de la tarea a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var tarea = tareas.FirstOrDefault(t => t.Id == id);
            if (tarea != null)
            {
                tareas.Remove(tarea);
                Console.WriteLine("Tarea eliminada.");
            }
            else
            {
                Console.WriteLine("No existe una tarea con ese ID.");
            }
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
    }

    public void Exportar()
    {
        File.WriteAllLines("tareas.txt", tareas.Select(t => t.AFormatoFichero()));
        Console.WriteLine("Tareas exportadas a 'tareas.txt'.");
    }

    public void Importar()
    {
        if (!File.Exists("tareas.txt"))
        {
            Console.WriteLine("El archivo 'tareas.txt' no existe.");
            return;
        }

        var lineas = File.ReadAllLines("tareas.txt");
        foreach (var linea in lineas)
        {
            var tarea = Tarea.DesdeFormatoFichero(linea);
            tareas.Add(tarea);
        }

        Console.WriteLine("Tareas importadas correctamente.");
    }

    public void MostrarTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para mostrar.");
        }
        else
        {
            Console.WriteLine("--- Lista de tareas ---");
            foreach (var tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
        }
    }
}
