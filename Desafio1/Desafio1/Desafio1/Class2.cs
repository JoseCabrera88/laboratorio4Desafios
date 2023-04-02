using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class CalculadoraCientifica
    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double Raiz(double num1)
        {
            return Math.Sqrt(num1);
        }

        public double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        public double Logaritmo(double num1, double num2)
        {
            return Math.Log(num1);
        }
    }
}
