using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemas_constructores_métodos_figuras
{
    internal class Formas
    {
        //Propiedades
        private int Area;
        private int Base;
        private int Altura;
        //Constructor
        public Formas()
        {
            Area = 6;
            Base = 10;
            Altura = 100;
        }
        //Metodos
        public void Imprimir_area_Triangulo()
        {
            Area = (Base * Altura) / 2;
            Console.WriteLine("El area del Triangulo es: " + Area);
        }
        public void Imprimir_area_Trapecio()
        {
            Area = (Base + Base * Altura) / 2; 
            Console.WriteLine("El area del Trapecio es: " + Area);
        }
    }
}
