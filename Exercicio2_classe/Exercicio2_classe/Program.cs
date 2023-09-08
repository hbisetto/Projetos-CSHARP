using System;
using System.Threading.Channels;
using TAD;

namespace Exercicio2_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double mediaSalarial = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salário médio = {0:F2}", mediaSalarial);

        }
    }
}
