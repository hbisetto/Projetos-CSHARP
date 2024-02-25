using System;
using TAD;

namespace Exercício1_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa n1, n2;
            n1 = new Pessoa();
            n2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            n1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            n1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            n2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            n2.idade = int.Parse(Console.ReadLine());

            if (n1.idade > n2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + n1.nome);
            }else
            {
                Console.WriteLine("Pessoa mais velha: " + n2.nome);
            }
        }
    }
}
