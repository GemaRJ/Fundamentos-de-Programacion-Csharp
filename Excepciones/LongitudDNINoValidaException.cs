

namespace FormularioAutomatizado
{
    public class LongitudDNINoValidaException : Exception
    {
        public LongitudDNINoValidaException()
            : base("El DNI debe tener exactamente 9 caracteres.") { }
    }

    public class UltimoDigitoNoLetraException : Exception
    {
        public UltimoDigitoNoLetraException()
            : base("El último carácter del DNI debe ser una letra.") { }
    }
}