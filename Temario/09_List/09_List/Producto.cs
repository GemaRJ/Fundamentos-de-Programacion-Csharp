public class Producto
{
    public string Nombre { get; set; } = string.Empty; // Nunca será null
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Producto() { }

    public Producto(string nombre, double precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public override string ToString()
    {
        return $"Producto{{nombre='{Nombre}', precio={Precio}, cantidad={Cantidad}}}";
    }
}