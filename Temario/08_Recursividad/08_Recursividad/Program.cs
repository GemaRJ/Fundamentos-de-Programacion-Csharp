using System;
using Controller;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesRecursivas operaciones = new OperacionesRecursivas();

            operaciones.CalculoFactorial();
            operaciones.CuentaAtras();
        }
    }
}
