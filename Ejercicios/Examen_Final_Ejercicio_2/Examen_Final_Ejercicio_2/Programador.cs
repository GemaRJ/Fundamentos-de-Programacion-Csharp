public class Programador : Empleado
{
    public string LenguajeFavorito { get; set; }

    // Constructor vacío
    public Programador() : base()
    {
    }

    // Constructor con parámetros
    public Programador(string nombre, int edad, decimal salario, string lenguajeFavorito)
        : base(nombre, edad, salario)
    {
        LenguajeFavorito = lenguajeFavorito;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + Nombre + ", Edad: " + Edad + ", Salario: " + Salario + " euros, Lenguaje favorito: " + LenguajeFavorito);
    }
}