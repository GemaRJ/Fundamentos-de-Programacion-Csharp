public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor vacío
    public Persona() { }

    // Constructor con parámetros
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad);
    }
}
