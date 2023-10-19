using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TAD
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area(double altura, double largura)
        {
            return altura * largura;
        }

        public double Perimetro(double altura, double largura)
        {
            return (2 * altura) + (2 * largura); 
        }

        public double Diagonal(double altura, double largura)
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
