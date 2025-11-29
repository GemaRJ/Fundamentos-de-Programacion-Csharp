public class Entrada
{
    public static void Main()
    {
        // Crear la lista de coches (tanto deportivos como todoterrenos)
        List<Coche> coches = new List<Coche>();

        // Crear dos coches deportivos y dos todoterrenos según enunciado
        Deportivo deportivo1 = new Deportivo("Ferrari", "F8", "1234ABC", 600, 3900, 250000, 650);
        Deportivo deportivo2 = new Deportivo("Porsche", "911", "5678DEF", 500, 3000, 100000, 600);
        TodoTerreno todoTerreno1 = new TodoTerreno("Jeep", "Wrangler", "1234GHI", 200, 3500, 45000, 4);
        TodoTerreno todoTerreno2 = new TodoTerreno("Land Rover", "Defender", "5678JKL", 300, 4000, 55000, 4);

        // Agregar los coches a la lista: Arraylist
        coches.Add(deportivo1);
        coches.Add(deportivo2);
        coches.Add(todoTerreno1);
        coches.Add(todoTerreno2);

        // Reprogramar los CV de todos los coches
        foreach (var coche in coches)
        {
            coche.ReprogramarMotor(); // Llamada al método de reprogramación
        }
        // Mostrar los datos de todos los coches según enunciado
        foreach (var coche in coches)
        {
            Console.WriteLine(coche.ToString());
        }
    }
}
