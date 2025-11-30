using System;

namespace Controller
{
    public class Metodo
    {
        // Método que solo imprime un saludo
        public void MetodoSaludar()
        {
            Console.WriteLine("Bienvenido a la ejecución de los métodos");
        }

        // Sobrecarga de métodos de división
        public double RealizarDivision()
        {
            return 4.0 / 2;
        }

        public double RealizarDivision(int operador1)
        {
            return 4.0 / operador1;
        }

        public double RealizarDivision(int operador1, int operador2)
        {
            return (double)operador1 / operador2;
        }

        public double RealizarDivision(double operador1, int operador2)
        {
            return operador1 / operador2;
        }

        public double RealizarDivision(int operador1, double operador2)
        {
            return operador1 / operador2;
        }

        // Método que calcula la media de un array de enteros
        public void CalcularMedia(int[] numeros)
        {
            double media = 0;
            int sumatorio = 0;
            foreach (int item in numeros)
            {
                sumatorio += item;
            }
            media = (double)sumatorio / numeros.Length;
            Console.WriteLine("La media calculada es " + media);
        }

        // Método que simula un cajero automático
        public void SacarDinero(int pin, int cantidad)
        {
            int saldo = 100;
            if (pin == 1234)
            {
                Console.WriteLine("Pin correcto");
                if (cantidad > saldo)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {
                    Console.WriteLine("Sacando dinero: " + cantidad);
                }
            }
            else
            {
                Console.WriteLine("Pin incorrecto");
            }
        }

        public override string ToString()
        {
            return "Clase Metodo";
        }
    }
}
