public class Empleado
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public decimal Salario { get; set; }

    // Constructor vacío
    public Empleado()
    {
    }

    // Constructor con parámetros
    public Empleado(string nombre, int edad, decimal salario)
    {
        Nombre = nombre;
        Edad = edad;
        Salario = salario;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Salario: " + Salario + " euros");
    }
}