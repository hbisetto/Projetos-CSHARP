using System;
using System.Globalization;

namespace Course2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("--------------------");

            //Novas variáveis
            char genero = 'F';
            int idade = 32;
            double saldo = 10.45243141;
            string nome = "Maria";
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2")); //arredonda considerando duas casas decimais
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); //Imprimir com . ao invés de , (para marcar as casas decimais)
            Console.WriteLine(nome);
        }
    }
}
