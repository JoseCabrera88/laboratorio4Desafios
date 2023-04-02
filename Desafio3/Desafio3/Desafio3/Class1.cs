

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Desafio3;

namespace Desafio3
{
    class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //Constructor parametrizado
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0} - Color: {1}", HP, Color);
        }

        public virtual void Reparar()
        {
            Console.WriteLine("El auto ya está reparado");
        }
        public void HistoriaDeReparaciones() 
        {
            string[] lineas = { "El Audi A4 está reparado", "El BMW M3 está reparado"};

            File.WriteAllLines(@"C:\Users\josec\OneDrive\Escritorio\PROGRAMACION I\Desafios en clase 4\Desafio3\Desafio3\Desafio3\HistoriaDeReparaciones123.txt", lineas);
        }
        
    }
}