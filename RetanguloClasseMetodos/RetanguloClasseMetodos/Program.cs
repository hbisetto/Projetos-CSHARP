using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml;
using TAD;

namespace RetanguloClasseMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo;
            retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area_ = retangulo.Area(retangulo.Altura, retangulo.Largura);
            Console.WriteLine("AREA = " + area_.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro(retangulo.Altura, retangulo.Largura).ToString("F2", CultureInfo.InvariantCulture) );

            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal(retangulo.Altura, retangulo.Largura).ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
