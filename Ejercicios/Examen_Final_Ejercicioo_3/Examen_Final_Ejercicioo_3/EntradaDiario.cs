using System;

public class EntradaDiario
{
    public DateTime Fecha { get; set; }
    public string Titulo { get; set; }
    public string Contenido { get; set; }

    // Constructor vacío
    public EntradaDiario()
    {
    }

    // Constructor con parámetros para facilitar creación
    public EntradaDiario(DateTime fecha, string titulo, string contenido)
    {
        Fecha = fecha;
        Titulo = titulo;
        Contenido = contenido;
    }

    public string FormatearEntrada()
    {
        return "Titulo: " + Titulo + ", Contenido: " + Contenido + ", Fecha: " + Fecha.ToString();
    }
}