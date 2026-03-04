public class Profesor : Persona
{
    public string Asignatura { get; set; }
    public int AniosExperiencia { get; set; }

    // Constructor vacío
    public Profesor() { }

    // Constructor con parámetros (incluye los de Persona)
    public Profesor(string nombre, int edad, string asignatura, int aniosExperiencia)
        : base(nombre, edad)
    {
        Asignatura = asignatura;
        AniosExperiencia = aniosExperiencia;
    }

    public override void Mostrar()
    {
        Console.WriteLine("Profesor - Nombre: " + Nombre + ", Edad: " + Edad + ", Asignatura: " + Asignatura + ", Años de experiencia: " + AniosExperiencia);
    }
}
