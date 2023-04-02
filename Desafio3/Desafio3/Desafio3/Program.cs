using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio3;

///Modifique la clase Auto y agregue un metodo HistoriaDeReparaciones, que almacene en una lista todas las reparaciones.
///Luego modifique la clase BMW para que al invocar el metodo reparar se guarde en archivo de texto y HistoriaDeReparaciones lea este archivo e imprima.

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>
            {
                new Audi(200,"azul","A4"),
                new BMW(250, "rojo","M3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW(200, "negro", "Z3");
            Auto auto2 = new Audi(100, "verde", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles();

            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();

            Console.Read();
        }
    }
}

