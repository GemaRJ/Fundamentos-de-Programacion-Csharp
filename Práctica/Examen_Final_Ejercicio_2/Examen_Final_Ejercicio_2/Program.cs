class Program
{
    static void Main(string[] args)
    {
        // Crear tres empleados
        Empleado e1 = new Empleado("Ana", 30, 2500m);
        Empleado e2 = new Empleado("Luis", 45, 3000m);
        Empleado e3 = new Empleado("Marta", 28, 2200m);

        // Crear tres programadores
        Programador p1 = new Programador("Carlos", 35, 3200m, "C#");
        Programador p2 = new Programador("Sofía", 29, 3100m, "Java");
        Programador p3 = new Programador("Javier", 40, 3500m, "Python");

        // Crear lista tipada de empleados
        List<Empleado> listaEmpleados = new List<Empleado>();

        listaEmpleados.Add(e1);
        listaEmpleados.Add(e2);
        listaEmpleados.Add(e3);
        listaEmpleados.Add(p1);
        listaEmpleados.Add(p2);
        listaEmpleados.Add(p3);

        // Recorrer lista y mostrar información
        foreach (Empleado empleado in listaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }
}