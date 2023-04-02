using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Marca = "Casio";
            calculadora.Serie = "fx-570LA X";

            double suma = calculadora.Sumar(324.543, 12.94);
            double resta = calculadora.Restar(30, 8);
            double multiplicacion = calculadora.Multiplicar(12, 3);
            double division = calculadora.Dividir(15048, 5);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Calculadora: ");
            Console.WriteLine("Marca de la calculadora: " + calculadora.Marca);
            Console.WriteLine("Serie de la calculadora: " + calculadora.Serie);
            Console.WriteLine("Resultado de la suma: " + suma);
            Console.WriteLine("Resultado de la resta: " + resta);
            Console.WriteLine("Resultado de la multiplicacion: " + multiplicacion);
            Console.WriteLine("Resultado de la division: " + division);

            Console.WriteLine(" ");

            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "Texas Instruments";
            calculadoraCientifica.Serie = "TI-30XS";

            double potencia = calculadoraCientifica.Potencia(8, 2);
            double raiz = calculadoraCientifica.Raiz(100);
            double modulo = calculadoraCientifica.Modulo(50, 5);
            double logaritmo = calculadoraCientifica.Logaritmo(35, 7);

            Console.WriteLine(" ");
            Console.WriteLine("Calculadora Cientifica: ");
            Console.WriteLine("Marca de la calculadora cientifica: " + calculadoraCientifica.Marca);
            Console.WriteLine("Serie de la calculadora cientifica: " + calculadoraCientifica.Serie);
            Console.WriteLine("Resultado de la potencia: " + potencia);
            Console.WriteLine("Resultado de la raiz: " + raiz);
            Console.WriteLine("Resultado del modulo: " + modulo);
            Console.WriteLine("Resultado del logaritmos: " + logaritmo);

            Console.ReadKey();
        }
    }
}
