public class Tarea
{
    private static int contadorId = 1;
    public int Id { get; private set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public TipoTarea Tipo { get; set; }
    public bool Prioridad { get; set; }

    public Tarea(string nombre, string descripcion, TipoTarea tipo, bool prioridad)
    {
        Id = contadorId++;
        Nombre = nombre;
        Descripcion = descripcion;
        Tipo = tipo;
        Prioridad = prioridad;
    }

    public void AsignarId(int id)
    {
        Id = id;
        if (id >= contadorId)
        {
            contadorId = id + 1;
        }
    }

    public string AFormatoFichero()
    {
        return Id + "|" + Nombre + "|" + Descripcion + "|" + Tipo + "|" + Prioridad;
    }

    public static Tarea DesdeFormatoFichero(string linea)
    {
        var partes = linea.Split('|');
        var tarea = new Tarea(partes[1], partes[2], (TipoTarea)Enum.Parse(typeof(TipoTarea), partes[3]), bool.Parse(partes[4]));
        tarea.AsignarId(int.Parse(partes[0]));
        return tarea;
    }

    public override string ToString()
    {
        return "ID: " + Id + " - Nombre: " + Nombre + " - Tipo: " + Tipo + " - Prioridad: " + (Prioridad ? "Alta" : "Baja");
    }
}
