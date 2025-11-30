using System;

namespace Controller
{
    public class OperacionesRecursivas
    {
        // Método para calcular el factorial de un número
        public void CalculoFactorial()
        {
            Console.WriteLine("Introduce un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine() ?? "0"); // Posible valor nulo convertido a 0
            int resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }

        // Método recursivo para calcular factorial
        private int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        // Método para cuenta atrás
        public void CuentaAtras()
        {
            Console.WriteLine("Introduce un número para cuenta atrás:");
            int numero = int.Parse(Console.ReadLine() ?? "0");
            CuentaAtrasRecursiva(numero);
        }

        // Método recursivo para cuenta atrás
        private void CuentaAtrasRecursiva(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("FIN");
            }
            else
            {
                Console.WriteLine(n);
                CuentaAtrasRecursiva(n - 1);
            }
        }
    }
}
