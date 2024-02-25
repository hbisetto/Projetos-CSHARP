using System;
using System.Globalization;
using Tad;

namespace AumentoSalarialClassesFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;
            funcionario = new Funcionario();

            Console.Write("Nome:");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double liquido = funcionario.Liquido();

            Console.WriteLine("Funcionário: {0}, $ {1}", funcionario.Nome, liquido.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite a porcentagem para aumentar do salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            //Console.WriteLine("Salario: {0}", funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Imposto: {0}", funcionario.Imposto.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Liquido desatualizado: {0}", liquido.ToString("F2", CultureInfo.InvariantCulture));


            liquido = funcionario.Liquido();
            Console.WriteLine("Dados atualizados: {0}, $ {1}", funcionario.Nome, liquido.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
