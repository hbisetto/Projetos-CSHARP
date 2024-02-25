using System;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 34;
            double saldo = 45.6543;
            string nome = "Maria";

            //Tipos de saídas de dados:

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e está com o saldo de R${2:F2}.", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e está com o saldo de R${saldo:F2}.");

            //Concatenação de strings
            Console.WriteLine(nome + " tem " + idade + " anos e está com o saldo de R$" + saldo.ToString("F2") + ".");

        }
    }
}
