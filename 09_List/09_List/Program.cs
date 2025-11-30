using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista dinámica de productos
            List<Producto> productos = new List<Producto>();

            // 1. Agregar productos
            productos.Add(new Producto("Leche", 1.5, 10));
            productos.Add(new Producto("Pan", 0.8, 20));
            productos.Add(new Producto("Huevos", 2.5, 12));
            productos.Add(new Producto("Queso", 3.0, 5));

            Console.WriteLine("Lista inicial de productos:");
            Listar(productos);

            // 2. Obtener tamaño
            Console.WriteLine("Cantidad de productos: " + productos.Count);

            // 3. Comprobar si está vacía
            Console.WriteLine("¿La lista está vacía? " + (productos.Count == 0));

            // 4. Obtener un elemento
            Console.WriteLine("Primer producto: " + productos[0]);

            // 5. Modificar un producto
            productos[1].Precio = 1.0; // cambiar precio del pan
            Console.WriteLine("Después de modificar el precio del pan:");
            Listar(productos);

            // 6. Eliminar un producto
            productos.RemoveAt(3); // elimina Queso
            Console.WriteLine("Después de eliminar Queso:");
            Listar(productos);

            // 7. Buscar un producto
            Console.WriteLine("¿Contiene Pan? " +
                productos.Any(p => p.Nombre == "Pan"));

            // 8. Iterar con foreach
            Console.WriteLine("Iterando con foreach:");
            foreach (Producto p in productos)
            {
                Console.WriteLine(p);
            }

            // 9. Convertir List a array
            Producto[] arrayProductos = productos.ToArray();
            Console.WriteLine("Array de productos:");
            foreach (Producto p in arrayProductos)
            {
                Console.WriteLine(p);
            }

            // 10. Ordenar productos por precio ascendente
            productos.Sort((p1, p2) => p1.Precio.CompareTo(p2.Precio));
            Console.WriteLine("Productos ordenados por precio ascendente:");
            Listar(productos);

            // 11. Ordenar productos por precio descendente
            productos.Sort((p1, p2) => p2.Precio.CompareTo(p1.Precio));
            Console.WriteLine("Productos ordenados por precio descendente:");
            Listar(productos);
        }

        // Método para listar productos
        static void Listar(List<Producto> lista)
        {
            foreach (Producto p in lista)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");
        }
    }
}