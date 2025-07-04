public class Estudiante : Persona
{
    public string Carrera { get; set; }
    public int Curso { get; set; }

    // Constructor vacío
    public Estudiante() { }

    // Constructor con parámetros (incluye los de Persona)
    public Estudiante(string nombre, int edad, string carrera, int curso)
        : base(nombre, edad)
    {
        Carrera = carrera;
        Curso = curso;
    }

    public override void Mostrar()
    {
        Console.WriteLine("Estudiante - Nombre: " + Nombre + ", Edad: " + Edad + ", Carrera: " + Carrera + ", Curso: " + Curso);
    }
}
