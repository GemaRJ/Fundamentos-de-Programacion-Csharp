using System;
using System.Collections.Generic;

class Programa
{
    // Lista de usuarios registrados
    static List<Usuario> usuarios = new List<Usuario>();
    static Usuario usuarioActual = null;
    
    
    static void Main(string[] args)
    {
       
        bool salir = false;
        while (!salir)
        {
            // Limpiamos la consola cada vez que se vuelve al menú principal
            Console.Clear();

            // Menú principal
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarUsuario();
                    break;
                case "2":
                    IniciarSesion();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Función para registrar un nuevo usuario
    static void RegistrarUsuario()
    {
        Console.Clear();
        Console.Write("Ingrese el correo: ");
        string correo = Console.ReadLine();
        
        // Verificar si el correo ya está registrado
        if (usuarios.Exists(u => u.Correo == correo))
        {
            Console.WriteLine("Ya existe un usuario con ese correo. Intente nuevamente.");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese la contraseña: ");
        string contraseña = Console.ReadLine();

        // Crear el nuevo usuario y agregarlo a la lista
        usuarios.Add(new Usuario(correo, contraseña));
        Console.WriteLine("Usuario registrado exitosamente.");
        Console.ReadKey();
    }

    // Función para iniciar sesión con un usuario
    static void IniciarSesion()
    {
        Console.Clear();
        Console.Write("Ingrese su correo: ");
        string correo = Console.ReadLine();

        // Buscar el usuario por correo
        Usuario usuario = usuarios.Find(u => u.Correo == correo);
        if (usuario == null)
        {
            Console.WriteLine("Usuario no encontrado. Presione una tecla para continuar.");
            Console.ReadKey();
            return;
        }

        Console.Write("Ingrese su contraseña: ");
        string contraseña = Console.ReadLine();

        // Verificar la contraseña
        if (usuario.Contraseña != contraseña)
        {
            Console.WriteLine("Contraseña incorrecta. Presione una tecla para continuar.");
            Console.ReadKey();
            return;
        }

        // Iniciar sesión
        usuarioActual = usuario;
        Console.WriteLine($"Bienvenido, {usuario.Correo}. Presione una tecla para continuar.");
        Console.ReadKey();

        // Menú de opciones después de iniciar sesión
        MostrarMenuSesion();
    }

    // Mostrar el menú de opciones después de iniciar sesión
    static void MostrarMenuSesion()
    {
        bool salirSesion = false;
        while (!salirSesion)
        {
            Console.Clear();
            Console.WriteLine("1. Registrar un entrenamiento");
            Console.WriteLine("2. Listar entrenamientos");
            Console.WriteLine("3. Vaciar entrenamientos");
            Console.WriteLine("4. Cerrar sesión");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEntrenamiento();
                    break;
                case "2":
                    ListarEntrenamientos();
                    break;
                case "3":
                    VaciarEntrenamientos();
                    break;
                case "4":
                    CerrarSesion();
                    salirSesion = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Función para registrar un entrenamiento
    static void RegistrarEntrenamiento()
    {
        Console.Clear();
        Console.Write("Ingrese la distancia recorrida (en km): ");
        double distancia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tiempo empleado (en horas): ");
        double tiempo = Convert.ToDouble(Console.ReadLine());

        // Crear el entrenamiento y agregarlo a la lista del usuario
        usuarioActual.Entrenamientos.Add(new Entrenamiento(distancia, tiempo));
        Console.WriteLine("Entrenamiento registrado exitosamente.");
        Console.ReadKey();
    }

    // Función para listar los entrenamientos
    static void ListarEntrenamientos()
    {
        Console.Clear();
        if (usuarioActual.Entrenamientos.Count == 0)
        {
            Console.WriteLine("No hay entrenamientos registrados.");
        }
        else
        {
            Console.WriteLine("Entrenamientos registrados:");
            foreach (var entrenamiento in usuarioActual.Entrenamientos)
            {
                Console.WriteLine(entrenamiento);
            }
        }
        Console.ReadKey();
    }

    // Función para vaciar la lista de entrenamientos
    static void VaciarEntrenamientos()
    {
        Console.Clear();
        usuarioActual.Entrenamientos.Clear();
        Console.WriteLine("Entrenamientos vaciados.");
        Console.ReadKey();
    }

    // Función para cerrar sesión
    static void CerrarSesion()
    {
        usuarioActual = null;
        Console.WriteLine("Has cerrado sesión.");
        Console.ReadKey();
    }
}
