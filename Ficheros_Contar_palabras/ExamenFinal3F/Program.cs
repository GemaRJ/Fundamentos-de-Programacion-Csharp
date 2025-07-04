using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Actualiza la ruta del archivo a la ubicación que proporcionaste
        string rutaArchivo = @"C:\Users\GEMA\.vscode\ejercicio3.txt";

        Console.WriteLine("Ruta del archivo: " + rutaArchivo);
        Console.WriteLine("Contenido del archivo:");

        // Inicializar contadores de letras y palabras
        int numeroLetras = 0;
        int numeroPalabras = 0;

        try
        {
            // Leer todo el contenido del archivo
            string[] lineas = File.ReadAllLines(rutaArchivo);

            // Recorrer cada línea
            foreach (string linea in lineas)
            {
                // Mostrar el contenido de cada línea
                Console.WriteLine(linea);

                // Contar las letras en la línea
                foreach (char c in linea)
                {
                    if (char.IsLetter(c))
                    {
                        numeroLetras++;
                    }
                }

                // Contar las palabras en la línea
                string[] palabras = Regex.Split(linea.Trim(), @"\s+");
                numeroPalabras += palabras.Length;
            }
            // Mostrar el número total de letras y palabras
            Console.WriteLine("Contenido Total de Letas y Palabras:");
            Console.WriteLine("Número total de letras: " + numeroLetras);
            Console.WriteLine("Número total de palabras: " + numeroPalabras);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }
    }
}
