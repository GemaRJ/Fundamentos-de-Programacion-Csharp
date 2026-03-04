namespace FormularioAutomatizado
{
    public class Formulario
    {
        private string nombre, apellidos, dni;

        public void Menu()
        {
            bool completarFormulario = false;

            while (!completarFormulario)
            {
                Console.Clear();
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Rellenar nombre.");
                Console.WriteLine("2. Rellenar apellidos.");
                Console.WriteLine("3. Rellenar DNI.");
                Console.WriteLine("4. Finalizar.");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: RellenarNombre(); break;
                    case 2: RellenarApellidos(); break;
                    case 3: RellenarDNI(); break;
                    case 4: completarFormulario = Finalizar(); break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void RellenarNombre()
        {
            nombre = LeerCampo("nombre");
        }

        private void RellenarApellidos()
        {
            apellidos = LeerCampo("apellidos");
        }

        private void RellenarDNI()
{
    while (true)
    {
        try
        {
            Console.Write("Ingrese su DNI (9 caracteres, con letra al final): ");
            dni = Console.ReadLine();

            if (string.IsNullOrEmpty(dni))
            {
                Console.WriteLine("El DNI no puede estar vacío.");
                continue;
            }

            if (dni.Length != 9)
                throw new LongitudDNINoValidaException();

            if (!System.Char.IsLetter(dni[8]))
                throw new UltimoDigitoNoLetraException();

            break; // DNI válido
        }
        catch (LongitudDNINoValidaException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (UltimoDigitoNoLetraException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

        private string LeerCampo(string campo)
        {
            Console.Write($"Ingrese su {campo}: ");
            return Console.ReadLine();
        }

        private bool Finalizar()
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) || string.IsNullOrEmpty(dni))
            {
                Console.WriteLine("Faltan datos. No se puede finalizar.");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.WriteLine("\nFormulario completado:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine("Gracias por completar el formulario.");
            return true;
        }
    }
}
