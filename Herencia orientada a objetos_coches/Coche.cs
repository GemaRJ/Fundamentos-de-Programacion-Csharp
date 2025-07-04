public class Coche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Matricula { get; set; }
    public int Cv { get; set; }
    public int Cc { get; set; }
    public double Precio { get; set; }

    // Constructor con todos los datos
    public Coche(string marca, string modelo, string matricula, int cv, int cc, double precio)
    {
        Marca = marca;
        Modelo = modelo;
        Matricula = matricula;
        Cv = cv;
        Cc = cc;
        Precio = precio;
    }

    // Constructor vacío
    public Coche() { }

    public override string ToString()
    {
        return "Marca: " + Marca +
               ", Modelo: " + Modelo +
               ", Matricula: " + Matricula +
               ", CV: " + Cv +
               ", CC: " + Cc +
               ", Precio: " + Precio;
    }

    // Método reprogramarMotor
    public virtual void ReprogramarMotor()
    {
        // Lógica a implementar
    }
}
