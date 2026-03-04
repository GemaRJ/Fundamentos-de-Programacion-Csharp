using System;
using System.Collections.Generic;
using System.IO;

public class GestorDiario
{
    // Lista privada para controlar acceso
    private List<EntradaDiario> entradas;

    private readonly string archivo = "diario.txt";

    // Constructor vacío que inicializa la lista
    public GestorDiario()
    {
        entradas = new List<EntradaDiario>();
    }

    public void GuardarEntrada(EntradaDiario entrada)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(archivo, append: true))
            {
                sw.WriteLine(entrada.FormatearEntrada());
            }
            entradas.Add(entrada);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar la entrada: " + ex.Message);
        }
    }

    public void MostrarDiario()
    {
        Console.WriteLine("Contenido completo del diario:");
        try
        {
            using (StreamReader sr = new StreamReader(archivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el diario: " + ex.Message);
        }
    }
}