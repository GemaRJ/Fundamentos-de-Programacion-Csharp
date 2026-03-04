
class Programa
{
    static void Main()
    {
        List<Persona> personas = new List<Persona>();

        Console.WriteLine("Los datos de las Personas,son:");

        Estudiante est = new Estudiante("Lucía", 21, "Ingeniería Informática", 3);
        Profesor prof = new Profesor("Miguel", 50, "Programación", 25);

        personas.Add(est);
        personas.Add(prof);

        foreach (var persona in personas)
        {
            persona.Mostrar();
        }
    }
}
