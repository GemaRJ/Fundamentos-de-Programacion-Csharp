using System;

namespace Ejercicios
{
    public class Recursividad
    {
        // Método para sumar dos números
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        // Método para comprobar si un número es primo
        public bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            return EsPrimoRec(n, 2);
        }

        // Método recursivo para comprobar si un número es primo
        private bool EsPrimoRec(int n, int divisor)
        {
            if (divisor * divisor > n) return true;
            if (n % divisor == 0) return false;
            return EsPrimoRec(n, divisor + 1);
        }
    }
}
